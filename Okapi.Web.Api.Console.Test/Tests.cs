using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Okapi.Drivers;
using Okapi.Web.Api.Console.Test.Models;
using RestSharp;

namespace Okapi.Web.Api.Console.Test
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Search()
        {
            //Arrange
            //The two lines of code below can be replaced by your code which provides html content
            IManagedDriver driver = DriverPool.Instance.ActiveDriver.LaunchPage("https://www.google.com");
            string html = driver.Html;

            //Act
            RestClient client = new RestClient($"http://localhost:4476");
            RestRequest request = new RestRequest("/search", Method.POST);

            SearchRequestDTO requestDTO = new SearchRequestDTO
            {
                SearchText = "`Search` <input>",
                HtmlContent = html
            };

            request.AddJsonBody(requestDTO);
            IRestResponse restResponse = client.Execute(request);
            string content = restResponse.Content;
            ResponseDTO responseDTO = JsonConvert.DeserializeObject<ResponseDTO>(content);
        }

        [TestMethod]
        public void Record_document_xpaths()
        {
            //Arrange
            //The two lines of code below can be replaced by your code which provides html content
            IManagedDriver driver = DriverPool.Instance.ActiveDriver.LaunchPage("https://www.google.com");
            string html = driver.Html;

            //Act
            RestClient client = new RestClient($"http://localhost:4476");
            RestRequest request = new RestRequest("/record", Method.POST);

            RecordRequestDTO requestDTO = new RecordRequestDTO
            {
                HtmlContent = html,
                Size = 100
            };

            request.AddJsonBody(requestDTO);
            IRestResponse restResponse = client.Execute(request);
            string content = restResponse.Content;
            ResponseDTO responseDTO = JsonConvert.DeserializeObject<ResponseDTO>(content);
        }
    }
}
