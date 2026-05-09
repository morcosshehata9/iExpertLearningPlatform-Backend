# iExperts Learning Platform API

Backend API for the iExperts Learning Platform built with ASP.NET Core 8.


## 📂 Project Structure

```
iExpertsLearningPlatform/
│
├── iExpertsLearningPlatform/                  # ASP.NET Core 8 Backend
│   ├── Controllers/
│   │   └── ContactController.cs   # POST & GET endpoints
│   ├── DTOs/
│   │   ├── ContactRequestDto.cs   # Inbound validated payload
│   │   └── ContactResponseDto.cs  # Outbound response shape
│   ├── Models/
│   │   └── ContactMessage.cs      # EF Core domain entity
│   ├── Services/
│   │   ├── IContactService.cs
│   │   └── ContactService.cs      # Business logic + mapping
│   ├── Repositories/
│   │   ├── IContactRepository.cs
│   │   └── ContactRepository.cs   # EF Core data access
│   ├── Data/
│   │   └── AppDbContext.cs        # DbContext
│   ├── Program.cs                 # App bootstrap + DI
│   └── appsettings.json
│

## 🚀 Technologies Used

- ASP.NET Core 8
- Entity Framework Core
- InMemory Database
- Swagger
- RESTful API
- Dependency Injection
- CORS Configuration


## ⚙️ Features

- ✅ ASP.NET Core 8 **RESTful Web API**
- ✅ **Clean architecture** — Controller → Service → Repository
- ✅ **DTOs** for request/response separation
- ✅ **Data Annotations** validation (`[Required]`, `[EmailAddress]`, `[StringLength]`)
- ✅ **EF Core InMemory** database (swap-ready for SQL Server)
- ✅ **CORS** configured for Angular dev server
- ✅ Proper **HTTP status codes** (201, 200, 400, 500)
- ✅ **Swagger/OpenAPI** documentation included
- ✅ Dependency injection throughout

---

## ▶️ Getting Started

### 1️⃣ Clone the repository

```bash
git clone https://github.com/morcosshehata9/iExpertLearningPlatform-Backend.git
