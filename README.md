Product Management System
This repository contains a comprehensive Product Management System developed as part of a .NET Developer Recruitment Task. The project is built with a .NET backend and an Angular frontend, designed to demonstrate a full-stack implementation covering authentication, product management, and order management functionalities.

Table of Contents
Introduction
Technologies Used
Main Features
Project Structure
Backend Setup
Frontend Setup
Running the Application
Additional Information
Introduction
The Product Management System allows users to manage products, variants, and orders. The backend is built using ASP.NET Core Web API with a three-layer architecture, and the frontend is developed with Angular. This system ensures seamless interaction between the backend and frontend.

Technologies Used
Backend
.NET 8
ASP.NET Core Web API
Entity Framework Core
MS SQL Server 2022
Redis
PostgreSQL (optional)
JWT Token-based Authentication and Authorization
Frontend
Angular
Packages
System.IdentityModel.Tokens.Jwt
Stripe.net
StackExchange.Redis
Microsoft.IdentityModel.Tokens
Microsoft.EntityFrameworkCore.Tools
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Design
Microsoft.AspNetCore.Identity
AutoMapper
Microsoft.AspNetCore.Authentication.JwtBearer
Microsoft.AspNetCore.Authentication.OpenIdConnect
Main Features
Authentication & Authorization
Login, Logout, and Sign Up functionalities
Product Management
Create, view, update, and delete products and their variants
Order Management
Create, view, update, and delete orders
Additional Features
Web APIs
Redis for caching (storing shopping cart data)
Identity for user management
Automapper for object mapping
Lazy loading, paging, sorting, searching, and filtering
Payments handling via Stripe (including 3D secure)
Project Structure
Core: Contains entities and interfaces
Infrastructure: Contains DbContext, interface implementations, and services
API: Contains controllers and other relevant configurations
Backend Setup
Prerequisites:

Ensure Redis is installed. Download and install it from this link.
Build the Solution:

Open the project in Visual Studio 2022 and build the solution.
Database Setup:

Open appsettings.Development.json under the API project and configure the DefaultConnection.
In the Package Manager Console, run update-database to apply migrations.
Run the Project:

Set the API project as the startup project.
Ensure to select 'API' in the run button options (API, IIS Express, Container, WSL).
Run the project.
Frontend Setup
Navigate to the Angular Project Directory:

Clone the frontend project from this link.
Install Node Modules:

Run npm install to install all necessary packages.
Build the Angular Application:

Run ng build to build the project.
Run the Frontend:

Run ng serve to start the development server.
Running the Application
Backend:

Follow the steps in the Backend Setup section.
Frontend:

Follow the steps in the Frontend Setup section.
Access the Application:

Open your browser and navigate to http://localhost:4200 for the frontend and http://localhost:5000 for the backend API.
Additional Information
Redis
Redis is used for caching data to improve performance. In this project, Redis is primarily used to store the shopping cart data. This allows for quick retrieval and updates, enhancing the user experience during shopping sessions.

Stripe
Stripe is integrated to handle payment functionalities, including the latest EU standards and 3D secure authentication. You will need your own Stripe keys to test the payment features. Update the appsettings.json file with your Stripe keys.

Documentation and Code Quality
The project follows best practices in coding standards, including the use of Repository (Generic) design pattern with IUnitOfWork and ResponseCacheService for better code organization and maintainability.
