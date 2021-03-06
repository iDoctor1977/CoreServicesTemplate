using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using CoreServicesTemplate.Shared.Core.Models;
using CoreServicesTemplate.StorageRoom.Common.Interfaces.IFeatures;
using Microsoft.Extensions.DependencyInjection;

namespace CoreServicesTemplate.StorageRoom.Api.Controllers
{
    [ApiController]
    [Route("StorageRoom/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ICreateUserFeature _createUserFeature;
        private readonly IReadUsersFeature _readUsersFeature;

        public UserController(IServiceProvider service)
        {
            _createUserFeature = service.GetRequiredService<ICreateUserFeature>();
            _readUsersFeature = service.GetRequiredService<IReadUsersFeature>();
        }

        // POST: StorageRoom/User/Post
        [HttpPost]
        public async Task Post(UserApiModel model)
        {
            await _createUserFeature.HandleAsync(model);
        }

        // GET: StorageRoom/User/Get
        [HttpGet]
        public async Task<UsersApiModel> Get()
        {
            var result = await _readUsersFeature.HandleAsync();

            return result;
        }
    }
}
