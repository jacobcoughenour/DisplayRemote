using Microsoft.AspNetCore.Mvc;

namespace DisplayRemote.Controllers {
	[ApiController]
	[Route("[controller]")]
	public class DisplayConfigController : ControllerBase {

		private readonly ILogger<DisplayConfigController> _logger;

		public DisplayConfigController(ILogger<DisplayConfigController> logger) {
			_logger = logger;
		}

		[HttpGet]
		public IEnumerable<string> Get() {
			return Enumerable.Range(1, 5).Select(index => "test")
			.ToArray();
		}
	}
}