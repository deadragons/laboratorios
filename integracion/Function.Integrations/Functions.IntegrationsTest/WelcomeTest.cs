using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Functions.IntegrationsTest
{
    [Collection(nameof(TestCollections))]
    public class WelcomeTest
    {
        private TestFixture testFixture;
        private HttpResponseMessage httpResponseMessage;

        public WelcomeTest(TestFixture fixture)
        {
            testFixture = fixture;
        }
        [Fact]
        public async Task WhenfunctionIsInvoked() 
        {
            httpResponseMessage = await testFixture.Client.GetAsync("api/Welcome?name=Brandon");
            Assert.True(httpResponseMessage.IsSuccessStatusCode);
        }
        [Fact]
        public async Task WhenResponseEndWith()
        {
            httpResponseMessage = await testFixture.Client.GetAsync("api/Welcome?name=Brandon");
            Assert.EndsWith("successfully.", await httpResponseMessage.Content.ReadAsStringAsync());
        }
    }
}
