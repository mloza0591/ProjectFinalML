using RestSharp;
using System;
using System.Net;
using TechTalk.SpecFlow;

namespace TestProject3
{
    [Binding]
    public class GetPostsStepDefinitions
    {
        RestClient client= new RestClient("http://demostore.gatling.io/");
        RestRequest request= new RestRequest("api/product/{productid}", Method.Get);
        RestResponse response;

        [Given(@"I have an Id with value (.*)")]
        public void GivenIHaveAnIdWithValue(int p0)
        {
            request.AddUrlSegment("productid", p0);
        }

        [When(@"I send I get request")]
        public void WhenISendIGetRequest()
        {
            response = client.Execute(request);
        }

        [Then(@"I expected a valid code response")]
        public void ThenIExpectedAValidCodeResponse()
        {
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
