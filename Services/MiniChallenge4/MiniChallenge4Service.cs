namespace MiniChallenges2To4.Services.MiniChallenge4;

public class MiniChallenge4Service : IMiniChallenge4Service
{
    public List<string> prompt = new();

    public MiniChallenge4Service()
    {
        prompt.Add("If two numbers are different from each other, one must be greater. Give me two numbers.");
        prompt.Add("Number 1");
        prompt.Add("Number 2");
    }

    public List<string> CallPrompt()
    {
        return prompt;
    }

    public List<string> CompareNums(string num1, string num2)
    {
        prompt[1] = num1;
        prompt[2] = num2;
        double parsedNum1;
        double parsedNum2;

        bool parsed = true;
        if (parsed != double.TryParse(num1, out parsedNum1) || parsed != double.TryParse(num2, out parsedNum2))
        {
            prompt.Add("One of your inputs was not a valid number. They are not comparable.");
        }
        else
        {
            if (parsedNum1 == parsedNum2)
            {
                prompt.Add($"The first number, {parsedNum1}, is equal to the second number, {parsedNum2}. Why did you put the same number twice?");
                prompt.Add($"The second number, {parsedNum2}, is equal to the first number, {parsedNum1}. How dare you put the same number twice?");
            }
            else if (parsedNum1 < parsedNum2)
            {
                prompt.Add($"The first number, {parsedNum1}, is less than the second number, {parsedNum2}. It is a small number.");
                prompt.Add($"The second number, {parsedNum2}, is greater than the first number, {parsedNum1}. It is a big number.");
            }
            else
            {
                prompt.Add($"The first number, {parsedNum1}, is greater than the second number, {parsedNum2}. It is a big number.");
                prompt.Add($"The second number, {parsedNum2}, is less than the first number, {parsedNum1}. It is a small number.");
            }
        }
        return prompt;
    }
}