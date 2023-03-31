# Animal Shelter API
#### Special Project #12 for Epicodus, 31 March 2023
### by Mike Donovan

## Description

A C#/ASP.NET/EFCore API whose endpoints produce a list of available animal shelter animals. Includes custom parameters and pagination.

## Technologies Used
* C#
* ASP.NET Core
* Entity Framework Core
* Pomelo.EntityFrameworkCore.MySql
* Swashbuckle.AspNetCore
* Postman (optional)

The API was developed using the Microsoft.NET.Sdk.Web project SDK and targets the .NET 6.0 framework. It utilizes the Swashbuckle.AspNetCore package for generating Swagger documentation and the Pomelo.EntityFrameworkCore.MySql package for working with a MySQL database. The API's data layer is implemented using Entity Framework Core, with the Microsoft.EntityFrameworkCore and Microsoft.EntityFrameworkCore.Design packages included as dependencies.

## Further Exploration: Pagination

By default, this API returns a maximum of 10 animal records per request. If there are more than 10 records that match the query parameters, pagination can be used to retrieve additional records.

To paginate the results, the following query parameters can be added to the request:

- `page`: the page number to retrieve (e.g. `page=2`).
- `pageSize`: the number of records to return per page (e.g. `pageSize=50`).

For example, to retrieve the first page of 10 records, use the following endpoint:
`GET /api/animals`


To retrieve the first page of 20 records, use the following endpoint:
`GET /api/animals?pageSize=20`


To retrieve the second page of 20 records, use the following endpoint:
`GET /api/animals?page=2&pageSize=20`

Additionally, the API provides pagination metadata in the response headers. The `X-Pagination` header contains information about the total number of records, the current page, and the page size. This header can be used by client applications to implement their own pagination logic.

## Setup/Installation Instructions

1. Clone this repo.
2. In the repo folder, navigate to `AnimalShelterApi/` and open `appsettings.json.example`.
3. Replace `[YOUR-DB-NAME]`, `[YOUR-USER-HERE]`, and `[YOUR-PASSWORD-HERE]` with your own credentials.
4. Save the file as `appsettings.json`.
5. Open your shell (e.g., Terminal or GitBash).
6. Navigate to this project's production directory called "AnimalShelterApi".
7. If don't have the `dotnet-ef` package installed globally, run the command `dotnet tool install --global dotnet-ef --version 6.0.0`.
8. If you don't have the `Microsoft.EntityFrameworkCore.Design` package installed, run the command `dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0`.
9. Start a local development server with a program such as MySQL Workbench on port 3306.
10. Run `dotnet ef database update` in the command line.
11. Run `dotnet watch run` in the command line to start the project in development mode with a watcher.
12. Open the browser to _https://localhost:5001_. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. For more information, [visit the Microsoft documentation on dev-certs](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-dev-certs).

## API Endpoint Guide and Example
```
GET http://localhost:5000/api/animals/
```
* _Returns all animals in the database_ 

Example Return Response:
```
[
    {
      "animalId": 1,
      "species": "dog",
      "breed": "Chihuahua",
      "gender": "Male",
      "name": "Conan"
    },
    {
      "animalId": 2,
      "species": "cat",
      "breed": "ShortHair",
      "gender": "Female",
      "name": "Curtesia"
    },
    {
      "animalId": 3,
      "species": "dog",
      "breed": "GoldenRetriever",
      "gender": "Male",
      "name": "Chauncey"
    }
    ... etc.
]
```

```
GET http://localhost:5000/api/animals/{id}
```
* _Returns an animal with the matching animalId_
* _Replace {id} with the animalId you would like to GET_
* _Tip: You can find all animalId's from requesting GET http://localhost:5000/api/animals/_

Example Return Response for animalId = 5:
```
{
  "animalId": 5,
  "species": "dog",
  "breed": "Corgi",
  "gender": "Female",
  "name": "Ginger"
}
```

```
POST http://localhost:5000/api/animals/
```
* _Creates a new animal in the database_

Postman Example:  
Start a new POST request in Postman and enter the above URL. A POST request must have a request body when sending. 
To create a request body, click the Body tab located under where you entered the url, and select raw. In the dropdown menu to the right change Text to JSON.
Enter a JSON request body replacing "string" with the value you would like to enter.  

Example Request Body:
```
{
  "species": "dog",
  "breed": "Pug",
  "gender": "Male",
  "name": "Buster"
}
```

Example Return Response:
```
{
  "animalId": 23,
  "species": "dog",
  "breed": "Pug",
  "gender": "Male",
  "name": "Buster"
}
```

```
PUT http://localhost:5000/api/animals/{id}
```
* _Updates an existing animal in the database_

Postman Example:  
Start a new PUT request in Postman and enter the above URL. A PUT request must have a request body when sending.
To create a request body, click the Body tab located under where you entered the url, and select raw. In the dropdown menu to the right change Text to JSON.
Enter a JSON request body replacing "string" with the values you would like to enter and 0 with the animalId you would like to update. Note: You must enter an animalId in the request body, and the entire body's values must still be assigned with either new or old values.

Example Request Body for animalId = 2:
```
{
  "animalId": 2,
  "species": "cat",
  "breed": "LongHair", // changed from "ShortHair"
  "gender": "Female",
  "name": "Curtesia"
}
```
Click Send. You should then be able to request `GET http://localhost:5000/api/animals/2` and see a response that reflects the changes you made.

```
DELETE http://localhost:5000/api/animals/{id}
```
* _Deletes an existing animal from the database_

Postman Example:  
Start a new DELETE request in Postman and enter the above URL. Click Send. You should see a return status of 204 No Content.  
Confirm the animal was deleted by requesting GET http://localhost:5000/api/animals/{id} and seeing a return status of 404 Not Found.


## Optional Path Parameters
| Parameter | Type | Required | Description |
| :---: | :---: | :---: | --- |
| Species | String | Not Required | Returns animals of the specified species |
| Breed | String | Not Required | Returns animals of the specified breed |
| Gender | String | Not Required | Returns animals of the specified gender |
| Name | String | Not Required | Returns animals with the specified name |
| /{id} | Integer | Not Required | Returns one animal with the specified ID |

## Example Queries
```
https://localhost:5001/api/animals?species=dog&breed=Corgi
```
Example Response:
```
[
  {
    "animalId":5,
    "species":"dog",
    "breed":"Corgi",
    "gender":"Female",
    "name":"Ginger"
  },
  {
    "animalId":6,
    "species":"dog",
    "breed":"Corgi",
    "gender":"Male",
    "name":"Winston"
  }
]
```
***
```
https://localhost:5001/api/animals?species=cat&page=2&pageSize=3
```
Example Response:
```
[
    {
      "animalId": 9,
      "species": "cat",
      "breed": "LongHair",
      "gender": "Male",
      "name": "Mingus"
    },
    {
      "animalId": 11,
      "species": "cat",
      "breed": "ShortHair",
      "gender": "Male",
      "name": "Mingus"
    },
    {
      "animalId": 13,
      "species": "cat",
      "breed": "Siamese",
      "gender": "Male",
      "name": "Linus"
    }
  ]
```
***
```
https://localhost:5001/api/animals/6
```
Example Response:
```
{
  "animalId": 13,
  "species": "cat",
  "breed": "Siamese",
  "gender": "Male",
  "name": "Linus"
}
```

## Known Bugs

No known bugs.

## Legal

MIT License

Copyright (c) 2023 Mike Donovan

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.