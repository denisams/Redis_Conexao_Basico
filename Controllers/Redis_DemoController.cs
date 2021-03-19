using Microsoft.AspNetCore.Mvc;
using StackExchange.Redis;
using System.Collections.Generic;

namespace Redis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Redis_DemoController : ControllerBase
    {
        private readonly IDatabase _database;

        public Redis_DemoController(IDatabase database)
        {
            _database = database;
        }

        // GET: api/Cache?key=key
        [HttpGet]
        public string Get([FromQuery] string key)
        {
            return _database.StringGet(key);
        }

        // POST: api/Cache
        [HttpPost]
        public void Post([FromBody] KeyValuePair<string, string> keyValue)
        {
            _database.StringSet(keyValue.Key, keyValue.Value);
        }
    }
}
