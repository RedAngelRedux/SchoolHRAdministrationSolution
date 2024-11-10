namespace DelegateExamples;

delegate int CalculateDelegate(int operand1, int operand2);

public static class Arithmetic
{
    public static int AddIntegerValues(int operand1, int operand2)
    {
        return operand1 + operand2;
    }

    public static int SubtractIntegerValues(int operand1, int operand2)
    {
        return operand2 - operand1;
    }

    public static int MultiplyIntegerValues(int operand1, int operand2)
    {
        return operand1 * operand2;
    }
}

delegate void LogDelegate(string text);

public static class UI
{
    public static void LogTextToConsole(string text)
    {
        Console.WriteLine($"static - {DateTime.Now}: {text}");
    }

    public static void LogTextToFile(string text)
    {
        using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt"), true))
        {
            sw.WriteLine($"{DateTime.Now}: {text}");
        }
    }
}

public class Log
{
    public void LogTextToConsole(string text)
    {
        Console.WriteLine($"{DateTime.Now}: {text}");
    }

    public void LogTextToFile(string text)
    {
        using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt"), true))
        {
            sw.WriteLine($"{DateTime.Now}: {text}");
        }
    }
}