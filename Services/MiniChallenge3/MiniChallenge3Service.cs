namespace MiniChallenges2To4.Services.MiniChallenge3;

public class MiniChallenge3Service : IMiniChallenge3Service
{
    public List<string> prompt = new();

    public MiniChallenge3Service()
    {
        prompt.Add("What is your name, traveller? What time did you wake up today?");
        prompt.Add("Your name");
        prompt.Add("The time you woke up, ex. 7:30");
    }

    public List<string> CallPrompt()
    {
        return prompt;
    }

    public List<string> AddInfo(string name, string time)
    {
        prompt[1] = name;
        prompt[2] = time;
        prompt.Add($"So, traveller, your name is {name} and you woke up at {time}. You slept in.");
        return prompt;
    }
}