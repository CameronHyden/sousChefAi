using Microsoft.AspNetCore.Mvc;
using sousChefAi.Server.Services;
using System.Diagnostics;

namespace sousChefAi.Server.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class AiController : ControllerBase
    {
        private readonly OpenAiService _aiService;

        public AiController(OpenAiService aiService)
        {
            _aiService = aiService;
        }

        [HttpPost("ask")]
        public async Task<IActionResult> Ask([FromBody] string question)
        {
            var answer = await _aiService.AskCookingQuestion(question);
            return Ok(answer);
        }
    
    }
}
