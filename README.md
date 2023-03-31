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