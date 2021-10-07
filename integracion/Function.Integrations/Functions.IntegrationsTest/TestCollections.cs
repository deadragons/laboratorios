using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Functions.IntegrationsTest
{
    [CollectionDefinition(nameof(TestCollections))]
    public class TestCollections : ICollectionFixture<TestFixture>
    {
    }
}
