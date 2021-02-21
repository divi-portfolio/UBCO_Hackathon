## DIVI MANGLA  
# UBCO 2.0 HACKATHON - Space Travel

# GOAL:

3D Results/ AR Vision: https://imgur.com/a/pqvAbOi

My goal was to build an Augmented Reality planetary model of our solar system (programmatically). For ex: animate orbit of all planets, orbit of Hubble and International Space Station around Earth. Interactive augmented reality where the user can select various aformentioned views. (echoAR + Unity manage the Augmented Reality).

The goal was to write modularized code that would avoid hardcoding cartesian coordinates to allow for animations and different viewsets created via a user interface to send POST requests to echoAR API . Accomplished a somewaht working prototype, needs fine tuning and further development. I learnt a lot since I had not used any of the technologies going (aside from REST APIs) in and feel I can tackle the challenges better in version 2.0. 

RESULTS YOUTUBE VIDEO: https://www.youtube.com/watch?v=bFtGWuQ8Me0&list=PLdUcV8uRODRQ7xYU6gOGSW7xlpZS6FlLh&index=1

# Acknowledgements
The echoAR team is fantastic, Alon (CEO) and Bora E. (developer) are incredibly supportive. Awesome product as well. UBCO team for putting together the event.

# What tools were used? 
echoAR (GUI and REST API interface for 3d model Content Delivery Network) and Unity (for building relationships b/w models).   

# What did I do?
Uploaded 3D models, developed metadata, identified scaling factors for diameters, distance between planets and the interface of the Augemented reality API with Unity. 
I did the entire build. Understanding the echoAPI system and Unity system to write code C# in Unity to parse through objects, created custom classes to create dict with key:obj mapping to send POST Requests to the echoAR API. 

Why? To modularize testing of scaling factors, dimensions, and for future development of animating orbit. The POST requests work well for snapshots. Utilizing Unity's physics engine would be idea for building animations to not overload the REST API. 

# Challenges?
- The scaling is the most challenging aspect due to the vasntess of space, size of bodies, and limited space. I was able to get a working 3d example with scaling but not in AR. I did not have any time to rebuild and identify bugs as the android SDK was published end of the day. 

- AR testing is difficult b/c testing is done in Unity which does not have access to AR/Camera. In unity, the model works as expected. Rate limiting also needs to be taken into account for POST requests

- Planetary coordinates (orbits for time lapse, various eclipse, orbit of ISS and Hubble) . Too time consuming to collect, clean and serialize the data into JSON. Also, have not created data bases in Unity before.

- Sample 2D view of debugging for scaling: https://i.imgur.com/gdTN9WS.png

- Publishing the app via Unity is a time consuming process. Spent 7 hours understanding the connection between softwares and beign able to navigate the scripts.

- 4+ hours of connection outage to echoAR (maintenance during late night) halted development. 

- Unfamiliar with C#, as I'm used to writing in python.

- Understaffed and lack of time

-----------------------------------------------------------------


# Unity-ARFoundation-echoAR-example
Example Unity project with AR Foundation and echoAR integrated.

## Register
Don't have an API key? Make sure to register for FREE at [echoAR](https://console.echoar.xyz/#/auth/register).

## Setup
Follow the instructions on our [documentation page](https://docs.echoar.xyz/unity/adding-ar-capabilities) to [set your API key](https://docs.echoar.xyz/unity/adding-ar-capabilities#3-set-you-api-key).

## Run
* [Add the 3D model](https://docs.echoar.xyz/quickstart/add-a-3d-model) to the console.
* [Set the API key](https://docs.echoar.xyz/unity/using-the-sdk) in the `echoAR.cs` script inside the `echoAR\echoAR.prefab` using the the Inspector.
* [Build and run the AR application](https://docs.echoar.xyz/unity/adding-ar-capabilities#4-build-and-run-the-ar-application).

## Learn more
Refer to our [documentation](https://docs.echoar.xyz/unity/) to learn more about how to use Unity and echoAR.

## Support
Feel free to reach out at [support@echoAR.xyz](mailto:support@echoAR.xyz) or join our [support channel on Slack](https://join.slack.com/t/echoar/shared_invite/enQtNTg4NjI5NjM3OTc1LWU1M2M2MTNlNTM3NGY1YTUxYmY3ZDNjNTc3YjA5M2QyNGZiOTgzMjVmZWZmZmFjNGJjYTcxZjhhNzk3YjNhNjE).
