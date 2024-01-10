using Microsoft.AspNetCore.Mvc;
using MiniChallenges2To4.Services.MiniChallenge2;

namespace MiniChallenges2To4.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniChallenge2Controller : ControllerBase
{
    private readonly IMiniChallenge2Service _miniChallenge2Service;

    public MiniChallenge2Controller(IMiniChallenge2Service miniChallenge2Service)
    {
        _miniChallenge2Service = miniChallenge2Service;
    }

    [HttpGet]
    [Route("CallPrompt")]
     public List<string> CallPrompt()
    {
        return _miniChallenge2Service.CallPrompt();
    }

    [HttpPut]
    [Route("AddNumbers/{num1}/{num2}")]
    public List<string> AddNumbers(string num1, string num2)
    {
        return _miniChallenge2Service.AddNumbers(num1, num2);
    }
}
