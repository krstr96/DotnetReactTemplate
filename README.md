# Dotnet React Template
## How to run in development
- Run the **Backend** project (`dotnet run`)
- Run the **Frontend** project (`npm run start`)
- Navigate to [http://localhost:3000](http://localhost:3000) in your browser
- The **Frontend** project will proxy api calls to the **Backend** project
## How to run in production
- Publish the **Backend** project (`dotnet publish`)
- The **Frontend** project will automatically be built and assets published
- Run the **Backend** however you want (Docker/IIS/Executable)
- The **Backend** project will fallback to the assets published by the **Frontend** project