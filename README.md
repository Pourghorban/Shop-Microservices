# Shop-Microservices

A practice project for learning and implementing **Microservices Architecture** using **.NET 8** and modern tools. This project simulates an online shop with independent services, communication patterns, and clean architecture principles.

## 🏗️ Architecture
- **Microservices** (modular & scalable design)
- **Clean Architecture** (separation of concerns, maintainable codebase)
- **CQRS** (Command Query Responsibility Segregation for clear separation of read/write operations)
- **Communication** via **RabbitMQ** (message broker) and **GraphQL** (API gateway)

## 🚀 Technologies
- **.NET 8** (ASP.NET Core 8)
- **Docker** (containerization & orchestration)
- **RabbitMQ** (message broker)
- **GraphQL** (query language for APIs)
- **MediatR** (CQRS & request/response handling)
- **AutoMapper** (object mapping)
- **FluentValidation** (validation layer)
- **Ocelot** – API Gateway for routing requests to microservices

## 📦 Services (example)
- **User Service** – manage users & authentication
- **Product Service** – manage products & categories
- **Order Service** – handle orders & payments

## ⚙️ How to Run
1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/Shop-Microservices.git
   cd Shop-Microservices
