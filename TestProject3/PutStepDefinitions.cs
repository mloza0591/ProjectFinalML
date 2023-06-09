using RestSharp;
using System;
using System.Net;
using TechTalk.SpecFlow;

namespace TestProject3
{
    [Binding]
    public class PutStepDefinitions
    {
        RestClient restClient = new RestClient("http://demostore.gatling.io/");

        RestRequest request = new RestRequest("api/product/{productid}", Method.Put);

        RestResponse response;

        [Given(@"I want edit a product with id (.*)")]
        public void GivenIWantEditAProductWithId(int p0)
        {
            request.AddHeader("Authorization", "Bearer eyJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJhZG1pbiIsImlhdCI6MTY4NjI3NzQzNSwiZXhwIjoxNjg2MjgxMDM1fQ.FVk3ClsShm1Q3Bula3cDT4qZKGRyJVeW1Da4FtwQp_U");
            request.AddUrlSegment("productid", p0);
        }

        [Given(@"I edit a name with value (.*) and description with value (.*) and image with value (.*) and price with value (.*) and categoryId with value (.*)")]
        public void GivenIEditANameWithValueBlackGlassAndDescriptionWithValueBlackGlassAndImageWithValueBlack_Glass_JpgAndPriceWithValueAndCategoryIdWithValue(String p2, String p3, String p4, Decimal p0, int p1)
        {
            request.AddJsonBody(new { name = p2, description = p3, image = p4, price = p0, categoryId = p1 });

        }

        [When(@"I send I put request")]
        public void WhenISendIPutRequest()
        {
            response = restClient.Execute(request);
        }

        [Then(@"I expected a valid code response put")]
        public void ThenIExpectedAValidCodeResponsePut()
        {
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
