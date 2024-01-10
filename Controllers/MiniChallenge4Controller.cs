using Microsoft.AspNetCore.Mvc;
using MiniChallenges2To4.Services.MiniChallenge4;

namespace MiniChallenges2To4.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniChallenge4Controller : ControllerBase
{
    private readonly IMiniChallenge4Service _miniChallenge4Service;

    public MiniChallenge4Controller(IMiniChallenge4Service miniChallenge4Service)
    {
        _miniChallenge4Service = miniChallenge4Service;
    }

    [HttpGet]
    [Route("CallPrompt")]
     public List<string> CallPrompt()
    {
        return _miniChallenge4Service.CallPrompt();
    }

    [HttpPut]
    [Route("CompareNums/{num1}/{num2}")]
    public List<string> CompareNums(string num1, string num2)
    {
        return _miniChallenge4Service.CompareNums(num1, num2);
    }
}
