# Microgreen API

asp.net core web API connected to a local instance of MongoDB for development and internal use.

## Purpose

As our urban farm continues to grow the way we collect and keep track of our data needed to change.
The API was built in order for us to keep better track of orders, microgreen varieties,yields, and the techniques we utilize to grow.
We hope that collecting this data will enable us to increase yields, decrease time to harvest, and eventually provide access to valuable information for other farmers like ourselves.
As the need to increase local food security continues to grow world wide, we hope our project can inspire and empower others to embrace a distributed approach to agriculture to end hunger and support a greener future.

## Schema

Posted below is a sample of the current schema using an embedded model for quicker development.
...
"id": "5f9fb473bc4c78dd58090e0b",
"seedInformation": {
"name": "Purple Sango Radish",
"genus": "Brassica",
"source": "Kitizawa Seeds"
},
"orderInformation": {
"isPreordered": true,
"orderDate": "2020-10-21T07:00:00Z",
"dueDate": "2020-11-02T08:00:00Z",
"customerInformation": {
"name": "Teddy",
"address": "123 main",
"state": "WA",
"zipcode": 98004,
"phoneNumber": "555-5555",
"email": "Max@max.com"
}
},
"seedingRate": 30,
"plantedDate": "2020-10-24T00:00:00-07:00",
"harvestDate": "2020-11-01T00:00:00-08:00",
"daysUnderWeight": 2,
"daysUnderBlackOut": 2,
"harvestWeight": 320
}
...

## Functionality

- Full CRUD capability allowing users to GET, POST, PUT, and DELETE.
- The ability to GET all ordered trays.
- The ability to GET all trays not preordered for retail sales

## Next Tasks

- [] Run server side validation to ensure the cleanest data
- [] Add the ability to GET average yield per Microgreen Tray filtered by Variety, Genus, and Seed Source
- [] Add the ability to GET an estimate of harvest yields filtered by Variety, Genus, and Seed Source
