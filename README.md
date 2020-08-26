# MyProductsWebSite
Created an ASP.NET Core Web Application project.
First thing to notice is the wwwroot folder which is full of static stuff. It is there where I put my images and the json file, from which I will be pulling my data.
We can see some dynamic code in the "Pages" folder and the Program.cs and Startup.cs files as well.
Created a "Models" folder, where I can store my C# model files. Created one model for now in the form of a C# object, which will corespond with the data from the json file, and gave it appropriate properties. I've Overridden its ToString method using the JsonSerializer so that I can convert it to the json file string format.
In order for the code to be maintainable for the future as well I've added a Service for the json file. It's purpose is to get the Web host environment, locate the json file and get its filepath so that we can retrieve its data, convert it back via deserialization and save it in an IEnumerable array of Product. 
Since I created a new Json Product File Service, I added it in the "ConfigureServices" method at the "Startup" file as well, so that the program knows about it.
From the index.cshtml.cs page, I requested a JsonProductFileService by listing it in the arguments of the IndexModel constructor.
Since the index page should be able to list out Products, its model the index.cshtml.cs should have a list(or in this case IEnumerable) of those products. So I created it and assigned to it the actual products from the ProductService in the OnGet method.
In the end I created the visual stuff using html in the index file and some inline style css to make it somewhat pretty.
