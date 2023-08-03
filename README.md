# StudentAPI - Simple Student Records Management API

StudentAPI is a C# project built using .NET 7.0 that provides a simple RESTful API for managing student records. The API allows you to perform basic CRUD operations (Create, Read, Update, Delete) on student data and is backed by a SQL Server database.

## Features

- Get All Students: Retrieve a list of all students in the database.
- Get Student by ID: Retrieve a specific student by providing their unique ID.
- Add Student: Create a new student record by providing their first name, last name, email, and phone number.
- Update Student: Update an existing student's information using their ID.
- Delete Student: Remove a student record from the database using their ID.

## Prerequisites

Before running the project, ensure you have the following dependencies:

- .NET 7.0 SDK
- SQL Server (or SQL Server Express)

## Installation

1. Clone the repository to your local machine.
2. Open the solution file (`StudentAPI.sln`) using Visual Studio or your preferred C# IDE.
3. Set up the SQL Server database and update the connection string in the `appsettings.json` file to point to your database instance.

## Usage

1. Build and run the project.
2. Once the application is running, you can access the Swagger UI at `http://localhost:<port>/swagger` to interact with the API.
3. Use the Swagger UI to test the various endpoints and their functionalities.

## API Endpoints

- GET `/api/students`: Get all students.
- GET `/api/students/{id}`: Get a student by ID.
- POST `/api/students`: Create a new student.
- PUT `/api/students/{id}`: Update a student's information.
- DELETE `/api/students/{id}`: Delete a student.

## Sample Request

To create a new student, make a POST request to `/api/students` with the following JSON payload:

```json
{
  "firstName": "John",
  "lastName": "Doe",
  "email": "john.doe@example.com",
  "phone": "123-456-7890"
}
