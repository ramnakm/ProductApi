# ProductApi

ProductApi is a RESTful API built with ASP.NET Core (.NET 8) for managing products. It provides endpoints to create, read, update, and delete product records in a database.

## Features

- CRUD operations for products
- Entity Framework Core integration
- Data validation using data annotations
- Repository pattern for data access

## Technologies

- .NET 8
- C# 12
- ASP.NET Core Web API
- Entity Framework Core

## Getting Started

### Prerequisites

- .NET 8 SDK
- SQL Server or SQLite (or update `ProductDbContext` for your preferred database)

### Setup

1. Clone the repository: git clone [https://github.com/ramnakm/ProductApi.git] and cd ProductApi
2. Restore dependencies:
3. Update the connection string in `appsettings.json` as needed.
4. Apply database migrations: dotnet ef database update
5. Run the API: dotnet run --project ProductApi
6. The API will be available at `https://localhost:5001` (or as configured).

### API Endpoints

| Method | Endpoint           | Description                |
|--------|--------------------|----------------------------|
| GET    | /api/products      | Get all products           |
| GET    | /api/products/{id} | Get product by ID          |
| POST   | /api/products      | Add a new product          |
| PUT    | /api/products/{id} | Update an existing product |
| DELETE | /api/products/{id} | Delete a product           |

## Project Structure

- `ProductApi/` - Main API project
- `ProductApi.Tests/` - Test project for ProductApi

---

# ProductApi.Tests

ProductApi.Tests contains unit and integration tests for the ProductApi project.

## Running Tests

1. Navigate to the test project directory: cd ProductApi.Tests
2. Run the tests: dotnet test


## Test Coverage

- Repository tests
- Controller tests
- Model validation

---

## Contributing

Contributions are welcome! Please open issues or submit pull requests for improvements.

## License

This project is licensed under the MIT License.
    
