# MyProductsWebSite
Created an ASP.NET Core Web Application project.\
First thing to notice is the _wwwroot_ folder which holds static data, such as images and the json file.\
The representational logic is located in the _Pages_ folder.\
The _Models_ folder holds the C# model files. _Product.cs_ coresponds with the data from the json file, and holds the appropriate properties.\
The _Service_ folder currently holds only one service: _JsonFileProductService.cs_. This service is responcible for delivering the json data to the frontend for representation purposes. The service was added to the _ConfigureServices_ method at the _Startup_ file, as this is needed so that the service can be accessed.\
The _JsonProductFileService_ was added in the rguments of the _IndexModel_ constructor so that it can be used in the _index.cshtml.cs_ page.\
Since the index page should be able to list out products, its model the _index.cshtml.cs_ should have a list(or in this case _IEnumerable_) of those products. The actual products are loaded from the _ProductService_ in the _OnGet_ method.\
The representational logic uses html and css. The _site.css_ file was extended with two new css classes: _inStock_ and _outOfStock_.\
A _Delete_ button was added to each element alongside a _ButtonID_ property in the _Product.cs_ file.
