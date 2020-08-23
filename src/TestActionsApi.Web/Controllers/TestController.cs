using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using TestActionsApi.Web.Config;

namespace TestActionsApi.Web.Controllers
{
    [Route("~/")]
    public class TestController : ControllerBase
    {
        private readonly IOptions<TestOptions> _testOptions;

        public TestController(IOptions<TestOptions> testOptions)
        {
            _testOptions = testOptions ?? throw new ArgumentNullException(nameof(testOptions));
        }

        [HttpGet]
        public IActionResult TestAction() => Ok(new
        {
            Environment.MachineName,
            Environment.UserDomainName,
            Environment.ProcessorCount,
            DateTimeOffset.UtcNow,
            _testOptions.Value.Option1,
            _testOptions.Value.Option2,
            _testOptions.Value.Option3
        });
    }
}