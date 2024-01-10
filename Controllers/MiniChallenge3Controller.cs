using Microsoft.AspNetCore.Mvc;
using MiniChallenges2To4.Services.MiniChallenge3;

namespace MiniChallenges2To4.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniChallenge3Controller : ControllerBase
{
    private readonly IMiniChallenge3Service _miniChallenge3Service;

    public MiniChallenge3Controller(IMiniChallenge3Service miniChallenge3Service)
    {
        _miniChallenge3Service = miniChallenge3Service;
    }

    [HttpGet]
    [Route("CallPrompt")]
     public List<string> CallPrompt()
    {
        return _miniChallenge3Service.CallPrompt();
    }

    [HttpPut]
    [Route("AddInfo/{name}/{time}")]
    public List<string> AddInfo(string name, string time)
    {
        return _miniChallenge3Service.AddInfo(name, time);
    }
}