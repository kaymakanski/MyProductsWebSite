using Microsoft.AspNetCore.Hosting;
using Products.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace MyProductsWebSite.Services
{
    public class JsonFileProductService
    {
        //allowing to locate and retrieve the mydata.json file
        //so that it doesn't matter where it is located at any given time
        public JsonFileProductService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }
        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "mydata.json"); }
        }

        //retrieving the file via deserialization and saving the data in an IEnumerable array: Product[]
        public IEnumerable<Product> GetProducts()
        {
            using (var fileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Product[]>(fileReader.ReadToEnd());
            }
        }
    }
}
