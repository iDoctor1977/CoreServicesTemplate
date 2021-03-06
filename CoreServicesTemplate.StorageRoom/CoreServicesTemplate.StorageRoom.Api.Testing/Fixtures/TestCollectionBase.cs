using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace CoreServicesTemplate.StorageRoom.Api.Testing.Fixtures
{
    [CollectionDefinition("BaseTest")]
    public class TestCollectionBase : ICollectionFixture<TestFixtureBase>, IClassFixture<WebApplicationFactory<Startup>> { }
}
