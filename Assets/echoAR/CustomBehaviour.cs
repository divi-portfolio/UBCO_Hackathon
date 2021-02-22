/**************************************************************************
* Copyright (C) echoAR, Inc. 2018-2020.                                   *
* Use subject to the terms of the Terms of Service available at           *
* https://www.echoar.xyz/terms, or another agreement                      *
* between echoAR, Inc. and you, your company or other organization.       *
***************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

public class CustomBehaviour : MonoBehaviour
{
    [HideInInspector]
    public Entry entry;


    // Use this for initialization
    public string url = "https://console.echoAR.xyz";
    public string key = "frosty-star-0346";
    public string data_diameter = "Diameter";
    public string data_scale = "Scale";
    public string data_x = "x";
    // CREATE HASHMAP <str,str> of {planet_name : [entryID,diameter,scale]}
    // This is to initialize the starting diameter of each planet and to easily find an acceptable ratio
    // Diameters are a ratio against earth except the sun.
    // FAIL: TO DO: Make initialization a function of if user selection such as: "Show Solar System Orbit" or "Lunar Eclipse" or "International Space Station" or "Solar Eclipse"

    public class solarBody
        {
            public string entryID {get;set;}
            public string diameter {get;set;}
            public string Scale {get;set;}
            public string x {get;set;}
          };

    public Dictionary<string, solarBody> solarBodies = new Dictionary<string, solarBody>{
             {"Sun.glb", new solarBody {entryID="05aecbfd-3982-4199-b9e6-3975dfcab68f", diameter= "200", Scale= "1",x= "0"}},
             {"Earth.glb",new solarBody {entryID="a56b7f47-830f-4827-b85a-d04a3157d2af", diameter= "10", Scale= "1",x= "-2000"}},
             {"Mars.glb",new solarBody {entryID="16f76754-ac2a-45a2-81c7-48acebfe5e6b", diameter= "5.32", Scale= "1",x= "3000"}},
             {"Jupiter.glb",new solarBody {entryID="88f5337b-ec67-431b-b37c-95a9092600a9", diameter= "112.1", Scale= "1",x= "-5000"}},
             {"Venus.glb",new solarBody {entryID="af77c674-5bbd-44a1-9f49-ffad3503e7fe", diameter= "9.5", Scale= "1",x= "1500"}},
             {"Neptune.glb",new solarBody {entryID="5b2ad66c-f328-4a6e-ac3f-139319ec5e8d", diameter= "38.8", Scale= "1",x= "8000"}},
             {"Pluto.glb",new solarBody {entryID="87fc0859-5598-4d09-8c7d-36d57bf57316", diameter= "1.86", Scale= "1",x= "9000"}},
             {"Saturn.glb",new solarBody {entryID="6feb598b-318b-4f15-80e6-8095aa9e1c73", diameter= "94.5", Scale= "1",x= "6500"}},
             {"Mercury.glb",new solarBody {entryID="61ca9ec5-fa7f-4746-a2f5-794e8abf8945", diameter= "3.83", Scale= "1",x= "-1000"}},
             {"Uranus.glb",new solarBody {entryID="a22d9056-5d13-4267-8a88-e91858c7218b", diameter= "40", Scale= "1",x= "-7500"}},
             {"Moon.glb",new solarBody {entryID="92a2cbda-a698-4440-8153-50ee5ab92d00", diameter= "2", Scale= "1",x= "2200"}}
        };

    void Start()
    {

//         ADD MY CODE
//         GOALS:
//          1. DONE: UPDATE solarBody dict with Diameters, and scaling factor. NOTE: 1 UNIT  = 1m (physics).
//                   to initialize models with appropriate diameters and scaling factor
//          2. FAIL: CREATE JSON DATABASE for XYZ Coordinate of orbit for each day of the year
               // INITIAL XYZ Coordinates should be part of the JSON Database for XYZ. key:val IS LIKE time:[entryID,x,y,z]
//          3. DONE: CREATE FOR LOOP to POST data to echoAR in this void Start()

//        UPDATE DIAMETER
//        foreach(KeyValuePair<string,solarBody> entry in solarBodies){
//            // UnityEngine.Debug.Log(entry.Value.entryID);
//                StartCoroutine(UploadMetadata( url, key, entry.Value.entryID, data_diameter , entry.Value.diameter) );        }

//        UPDATE CARTESIAN X coordinate
        foreach(KeyValuePair<string,solarBody> entry in solarBodies){
                StartCoroutine(UploadMetadata( url, key, entry.Value.entryID, data_x , entry.Value.x) );            }

//        UPDATE SCALE
//        foreach(KeyValuePair<string,solarBody> entry in solarBodies){
//                StartCoroutine(UploadMetadata( url, key, entry.Value.entryID, data_scale, entry.Value.Scale) );            }

        // Move to void Update() update every frame
       // Add RemoteTransformations script to object and set its entry
        this.gameObject.AddComponent<RemoteTransformations>().entry = entry;

        // Query additional data to get the name
        string value = "";
        if (entry.getAdditionalData() != null && entry.getAdditionalData().TryGetValue("name", out value))
        {
            // Set name
            this.gameObject.name = value;
        }
}
    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator UploadMetadata(string url, string key, string entryID, string data, string value) {
      WWWForm form = new WWWForm();
      form.AddField("key", key);
      form.AddField("entry", entryID);
      form.AddField("data", data);
      form.AddField("value", value);

      using (UnityWebRequest www = UnityWebRequest.Post(url+"/post?", form))
      {
          yield return www.SendWebRequest();

          if (www.isNetworkError || www.isHttpError)
          {
              UnityEngine.Debug.Log(www.error);
          }
          else
          {
              UnityEngine.Debug.Log("Form upload complete!");
          }
      }
    }


}

