using RestSharp;
using System;
using System.Net;
using TechTalk.SpecFlow;

namespace TestProject3
{
    [Binding]
    public class GetAllStepDefinitions
    {
        RestClient client = new RestClient("http://demostore.gatling.io/");
        RestRequest request = new RestRequest("api/product/", Method.Get);
        RestResponse response;

        [Given(@"I have the url complement")]
        public void GivenIHaveTheUrlComplement()
        {
            
        }

        [When(@"I send I get all request")]
        public void WhenISendIGetAllRequest()
        {
            response = client.Execute(request);
        }

        [Then(@"I expected a valid code response get all")]
        public void ThenIExpectedAValidCodeResponseGetAll()
        {
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
