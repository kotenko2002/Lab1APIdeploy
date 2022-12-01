### Required for app to work
Installed [.NET 5.0](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-5.0.408-windows-x64-installer)  
Installed [ASP.NET Core 5.0 Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-aspnetcore-5.0.17-windows-x64-installer)

### How to download and run the app
Video instruction(1min): https://youtu.be/LasMPDeCI34
Write these 3 commands in a directory convenient for you:
```
git clone https://github.com/kotenko2002/Lab1APIdeploy.git
cd Lab1APIdeploy\Lab1API
dotnet run
```

### Endpoints
Video review on the API(5min): https://youtu.be/ZUaXotryUM4
Video explanation how I implemented the practical task - 1. Валюти: https://youtu.be/xWlCGxtnr1o
<br/>
You can use 2 domains:
* local: `localhost:5001`
* deployed: `lab1-dotnet.herokuapp.com`
<br/>
     
* UserController
    * Add new user: `{domain}/api/user`
    * Get All Currencies: `{domain}/api/user/currencies`
    * Change Default Сurrency: `{domain}/api/user/currency`
* CategoryController
    * Add new category: `{domain}/api/category`
    * Get list of all categories: `{domain}/api/category/items`
* RecordController
    * Add new record: `{domain}/api/record`
    * Get list of records by userId: `{domain}/api/record/items/{id}`
    * Get list of records by userId and categoryId: `{domain}/api/record/items/?userId={userId}&categoryId={categoryId}`

Example of GET request (you can try typing it in your browser right now):
`https://lab1-dotnet.herokuapp.com/api/category/items`
