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




























### <u>Table of Contents</u>
* <a href="#Description">Description</a>
* <a href="#Technologies-Used">Technologies Used</a>
* <a href="#Setup/Installation-Requirements">Setup/Installation Requirements</a>
* <a href="#Example-Query">Example Query and JSON Response</a>
* <a href="#API-Endpoints">API Endpoints</a>
* <a href="#Path-Parameters">Path Parameters</a>
* <a href="#Versions">Versions</a>
* <a href="#Known-Bugs">Known Bugs</a>
* <a href="#License">License</a>

## Description

_Arrested Development API is an API that when requested to GET all quotes by each character of the show, will return a response containing all quotes. Arrested Development API is seeded with over 400 quotes by each o the show's character database, but also has full Create, Update, and Delete functionality for any new or existing quotes._

## Further Exploration: Versioning 
_Versioning is the creation and management of multiple web API versions. How it is used here is to have a version 1 as a base minimum viable product, and have a version 2 as a working but work in progress version with additional code and comments_

## Technologies Used

* _C#_
* _.Net 6_
* _ASP.NET Core Web API_
* _Visual Studio Code 2019_
* _MySql_
* _MySql Workbench_
* _Entity Framework Core 6_
* _Pomelo Entity Framework Core 6 MySql_
* _ASP.NET Core Identity_
* _(Optional) Postman_

## Setup/Installation Requirements

* _Install .Net 6 SDK:_
* [OS X and Windows Instructions](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-c-and-net)
* _Setup MySql Workbench:_
* [OS X and Windows Instructions](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql)
* _Clone this repo to a local directory_
* _Navigate to the local directory (YourPath/ArrestedDevelopmentApi.Solution/ArrestedDevelopmentApi) and create a new file "appsettings.json" 
* _Open this file with Visual Studio Code 2019 and add:
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DB-NAME];uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}

```
replace [YOUR-USERNAME-HERE] and [YOUR-PASSWORD-HERE] with the your own user and password values, and [YOUR-DB-NAME] with any name you'd like to call the database, i.e. "arrested_development_api"_

* _Using Terminal on OS X or PowerShell on Windows navigate to the directory that this repo was cloned to, then the ArrestedDevelopmentApi folder (YourPath/ArrestedDevelopmentApi.Solution/ArrestedDevelopmentApi) and run the terminal commands (without the '$'):_ 
* _$ dotnet ef database update_
* _Making sure you've followed the MySqlWorkbench installation instructions, open MySql Workbench and select the Local 3306 server_
* _Confirm the database [YOUR-DB-NAME] that you named was successfully created by clicking on the "Schemas" tab and seeing the schema listed._ 
* _Then run the program with command :_
* _$ dotnet watch run_
* _This will autolaunch Swagger in your browser_
* _Test any API endpoints in Swagger, POSTMAN, or your own app_

## API Endpoint Guide and Example
```
GET http://localhost:5000/api/quotes/
```
* _Returns all quotes in the database_

Postman Example:  
Start a new GET request in Postman and enter the above URL. Click Send. You should see a JSON response with all quotes in the database.  

Example Return Response:
```
[
  {
    "quoteId": 2,
    "speaker": "Buster",
    "text": "What do you expect, Mother? I'm half machine!"
  },
  {
    "quoteId": 3,
    "speaker": "Buster",
    "text": "I'm a monster!"
  }
]
```

```
GET http://localhost:5000/api/quotes/{id}
```
* _Returns a quote with the matching quoteId_
* _Replace {id} with the quoteId you would like to GET_
* _Tip: You can find all quoteId's from requesting GET http://localhost:5000/api/quotes/ end point_

Postman Example:  
Start a new GET request in Postman and enter the above URL. Click Send. You should see a JSON response with the quote that matches the quoteId you entered.  
Example Return Response for quoteId equals 7:
```
{
    "quoteId": 7,
    "speaker": "Unknown",
    "text": "You could charm the black off a telegram boy"
}
```
```
POST http://localhost:5000/api/quotes/
```
* _Creates a new quote in the database_

Postman Example:  
Start a new POST request in Postman and enter the above URL. A POST request must have a request body when sending. 
To create a request body, click the Body tab located under where you entered the url, and select raw. In the dropdown menu to the right change Text to JSON.
Enter a JSON request body replacing "string" with the value you would like to enter.  
Example Request Body:
```
{
    "quoteId": 0,
    "speaker": "string",
    "text": "string"
}
```
Click Send. You should see a JSON response with the quote that you entered.

```
PUT http://localhost:5000/api/quotes/{id}
```
* _Updates a quote in the database_

Postman Example:  
Start a new PUT request in Postman and enter the above URL. A PUT request must have a request body when sending.
To create a request body, click the Body tab located under where you entered the url, and select raw. In the dropdown menu to the right change Text to JSON.
Enter a JSON request body replacing "string" with the values you would like to enter and 0 with the quoteId you would like to update. Note: You must enter an quoteId in the request body, and the entire body's values must still be assigned with either new or old values.  
Example Request Body:
```
{
  "quoteId": 0,
  "speaker": "string",
  "text": "string"
}
```
Click Send. You should see a JSON response with the quote that you updated.

```
DELETE http://localhost:5000/api/quotes/{id}
```
* _Deletes a quote in the database_

Postman Example:  
Start a new DELETE request in Postman and enter the above URL. Click Send. You should see a return status of 204 No Content.  
Confirm the quote was deleted by requesting GET http://localhost:5000/api/quotes/{id} and seeing a return status of 404 Not Found.


## Optional Path Parameters When Using Get All Quotes Endpoint
| Parameter | Type | Required | Description |
| :---: | :---: | :---: | --- |
| Speaker | String | Not Required | Returns the character that match the quote |
| Question | String | Not Required | Returns the quote that end with a question |

## Example Query
```
https://localhost:5001/api/quotes?question=true
```

## Example Returned JSON Response
```
{
    "quoteId": 8,
    "speaker": "Unknown",
    "text": "Did you see the new Poof?"
}
```

## Pagination
* _Paging refers to getting partial results from an API._ 
* _Change the pagesize to your desired number in the URL: https://localhost:5001/api/Quotes?maxWords=4&speaker=GOB&question=false&page=1&pageSize=4_

## Known Bugs

N/A

## License
Enjoy the site! If you have questions or suggestions for fixing the code, please contact me!

[MIT](https://github.com/git/git-scm.com/blob/main/MIT-LICENSE.txt)

Copyright (c) 2023 Brishna Bakshev, Kai Clausen, Mike Donovan