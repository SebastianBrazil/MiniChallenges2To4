namespace MiniChallenges2To4.Services.MiniChallenge2;

public class MiniChallenge2Service : IMiniChallenge2Service
{
    public List<string> prompt = new();

    public MiniChallenge2Service()
    {
        prompt.Add("Please input two numbers. If you do not, you forfeit your tax returns for this year");
        prompt.Add("Number 1");
        prompt.Add("Number 2");
        prompt.Add("Number 1 and Number 2 will be added together here.");
    }

    public List<string> CallPrompt()
    {
        return prompt;
    }

    public List<string> AddNumbers(string num1, string num2)
    {
        prompt[1] = num1;
        prompt[2] = num2;
        double parsedNum1;
        double parsedNum2;

        bool parsed = true;
        if (parsed != double.TryParse(num1, out parsedNum1) || parsed != double.TryParse(num2, out parsedNum2))
        {
            prompt[3] = "One of your inputs was not a valid number. No tax return for you.";
        }
        else
        {
            prompt[3] = $"{parsedNum1} and {parsedNum2} added together is equal to {parsedNum1 + parsedNum2}.";
        }
        return prompt;
    }
}