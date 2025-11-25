# Reactivities ASP.NET Core

Sample/Tutorial project for activity management built with ASP.NET Core.

## Overview

This repository demonstrates a clean architecture approach using ASP.NET Core for building an activities management application. It is designed as a sample/tutorial project to help you learn best practices in organizing and structuring a .NET Core backend with a modern architecture.

## Project Structure

- **API/** - Contains API controllers and startup configuration.
- **Application/** - Houses business logic and application services.
- **Domain/** - Defines core domain entities and interfaces.
- **Infrastructure/** - Contains infrastructure-related implementations (e.g., external services).
- **Persistence/** - Deals with data access (e.g., database context and migrations).
- **client-app/** - Frontend/client application (often built with React or similar).

## Technologies Used

- **.NET 8+ / ASP.NET Core**
- **C#**
- (Likely) Entity Framework Core for data access
- (Frontend in `client-app`—usually React, but see directory for details)

## Getting Started

1. **Clone the repo:**
   ```bash
   git clone https://github.com/Wiliperdana/Reactivities-ASPNET-Core.git
   cd Reactivities-ASPNET-Core
   ```
2. **Set up the backend:**
   - Open `Reactivities.sln` in Visual Studio or your favorite IDE.
   - Restore NuGet packages.
   - Configure your database connection in the `Persistence` project.
   - Apply migrations and update the database.
   - Run the API project.
3. **Set up the frontend (if applicable):**
   - Navigate to `client-app/`.
   - Follow instructions in the client directory (commonly `npm install` & `npm start` for React apps).

## Learning Objectives

- Understand Clean Architecture in ASP.NET Core
- Organize project folders by responsibility
- Implement API controllers, business logic, domain models, and infrastructure layers
