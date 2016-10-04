# Dreamforce'16 
##IOT Cloud & Heroku Enterprise: *Appliance Marketing iBeacon Ingestion App*

**How to Deploy & Configure the Demo**

* Ensure you have a [Heroku Account](https://signup.heroku.com) and are signed into it
* Click the Deploy to Heroku Button below
* Leave the pre-populated Configuration Vars as-is, unless asked to modify them
* Confirm the Deploy
* Watch the magic of IOT Cloud & Heroku together!

**What the Configuration Variables mean**

- `appID` - identifies the Heroku App to IOT Cloud as a "unique In-Store Loyalty Customer" and must be unique
- `iotToken` - allows IOT Cloud to authorize incoming messages to its Endpoint
- `endpointURL` - URL the Heroku App uses to send "iBeacon Proximity data to trigger Marketing event" (aka the IOT Endpoint)
- `IRON_MQ_PROJECT_ID` - allows the Heroku MQ listener to know where incoming messages should be stored (where its queues live)
- `IRON_MQ_TOKEN` - allows the Heroku MQ to authorize incoming messages from IOT Cloud to its Queue Endpoint
- `queueURL` - URL the IOT Cloud Orchestration uses to send "iBeacon Proximity data to trigger Marketing event" (aka the Heroku App Endpoint)

**Technologies Used in this Demo**

1. Heroku Enterprise: *used to generate large amounts of real-world data & send it to the IOT Cloud endpoint*
2. IOT Cloud: *handles message ingestion, orchestration & business workflow for the 'Heroku IOT Demo App'*
3. Heroku MQ (Message Queue) Add-On: *used to handle UX change responses from IOT Cloud to the Heroku App*
4. ASP.NET Core: *language the Heroku App was written in (refer to [.NET Buildpack Support](http://www.dotnetbuildpacks.com))*

[![Deploy](https://www.herokucdn.com/deploy/button.svg)](https://heroku.com/deploy?template=https://github.com/heroku-softtrends/DF-Appliance)

**What to Expect Once Deployed**

![alt text](https://s3.amazonaws.com/herokumximages/heroku-appliance.png "Heroku IOT Cloud In-Store Proximity Marketing")

1. Click *"Start Sending Data"* to begin sending *"iBeacon Proximity"* location data and display the Shopper's Loyalty Card
2. To simulate the Shopper getting closer to the in-store Appliance Dept., drag the *"Proximity to iBeacon"* slider to the right
3. Once you drag the slider to under 25 feet from the iBeacon device, you will see a Marketing Event fire and offer a Today-Only Discount
4. To simulate the Shopper moving farther away from the in-store Appliance Dept., drag the *"Proximity to iBeacon"* slider to the left
5. Once the slider is greater than 25 feet from the iBeacon, the Marketing event stops firing and returns to the Shopper's Loyalty Card

**Support or Questions**

* Contact [us](mailto:david@heroku.com) if you have any questions about this Dreamforce'16 IOT Cloud & Heroku Demo
