## DIVI MANGLA  
# UBCO 2.0 HACKATHON - Space Travel (EchoAR - Winner)

3D Results/ AR Vision: https://imgur.com/a/pqvAbOi
RESULTS YOUTUBE VIDEO: https://tinyurl.com/ya3umk5m

#Goal
Build an Augmented Reality model of our solar system (programmatically	). For ex: animate orbit of all planets, orbit of Hubble and International Space Station around Earth. Buttons to switch between modes. (echoAR + Unity manage the Augmented Reality). Avoid hardcoding coordinates to make animations.Made a working prototype. New to the stack.: C#,  echoAR , Unity


# What tools were used? 
echoAR (GUI and REST API interface for 3d model Content Delivery Network) and Unity (for building relationships b/w models).  The echoAR team is very active.


# What did I do?
Uploaded 3D models, developed metadata, identified scaling factors for diameters, distance between planets and conneted echoAR to Unity. 
 Sent POST Requests to the echoAR API and map it to planets.

Why? To make testing of property values and animations easier. The POST requests work well for snapshots. Utilizing Unity's physics engine seems more robust for building animations to not overload the API.

# Challenges?

The scaling was challenging due to the large distances and small planets. Got a working scaled example in 3D not in AR.

AR testing is difficult since development testing is done in Unity which does not support AR. In Unity, the model works as expected. 

Planetary coordinates . Too time consuming to collect accurate and clean data

Unfamiliar with stack.

New to stack. 
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
