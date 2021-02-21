## DIVI MANGLA  
# UBCO 2.0 HACKATHON - Space Travel

#GOAL:
My goal was to build a Augmented Reality planetary model of our solar system. Accomplished a somewhat working prototype, needs fine tuning and further development. I learnt a lot as I had not used any of the technologies going in and feel I can tackle the challenges better in version 2.0. 

RESULTS YOUTUBE VIDEO: https://www.youtube.com/watch?v=bFtGWuQ8Me0&list=PLdUcV8uRODRQ7xYU6gOGSW7xlpZS6FlLh&index=1

#Acknowledgements
The echoAR team is fantastic, Alon (CEO) and Bora E. (developer) are incredibly supportive. Awesome product as well. UBCO team for putting together the event.


#What tools were used? 
echoAR (REST API interface for 3d model CDN) and Unity (for building relationships b/w models).  

I had not used C#, Unity, echoAR prior to the project. 

#What did I do?
Uploaded 3D models, developed metadata, tried to identify scaling factors for diameters, distance between planets and the interface of the Augemented reality. 

I used C# in Unity to parse through objects, created custom classes to create dict with key:obj mapping to send POST Requests to the echoAR API. Why? To modularize testing of scaling factors, dimensions, and for future development of animating orbit. The POST requests work well for snapshots. Utilizing Unity's physics engine would be idea for building animations to not overload the REST API.

#Challenges?
The scaling is the most challenging aspect due to the vasntess of space, size of bodies, and limited space. 
Testing is difficult b/c testing is done in Unity which does not have access to AR. In unity, the model works as expected (kind of) 

https://i.imgur.com/gdTN9WS.png

Publishing the app via Unity is a time consuming process. Most of the work was done under 5 hours after spending 7 hours understanding the connection between softwares and beign able to navigate the scripts.

4 hours of connection outage to echoAR (maintenance during late night) halted development.

Solo development mode.




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
