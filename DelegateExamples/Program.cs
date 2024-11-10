using DelegateExamples;

// Example One
CalculateDelegate Add = new CalculateDelegate(Arithmetic.AddIntegerValues);
CalculateDelegate Subtract = new CalculateDelegate(Arithmetic.SubtractIntegerValues);
CalculateDelegate Multipy = new CalculateDelegate(Arithmetic.MultiplyIntegerValues);

Console.WriteLine($"Sum = {Add(10,5)}");
Console.WriteLine($"Difference = {Subtract(10,5)}");
Console.WriteLine($"Product = {Multipy(10,5)}");

// Example Two - Reference Static Methods
Console.Write("Please enter your name: ");
var name = Console.ReadLine();

LogDelegate logDel = new LogDelegate(UI.LogTextToConsole); 
logDel(name!);

logDel = new LogDelegate(UI.LogTextToFile);
logDel(name!);

// Example Three - Reference Instance Methods
Log log = new();

LogDelegate logToScreen = new LogDelegate(log.LogTextToConsole);
LogDelegate logToFile = new LogDelegate(log.LogTextToFile); 

logToScreen("ExThree"!);
logToFile("ExThree"!);

// Example Four - Multicast Delegate
LogDelegate LogTextToScreen, LogTextToFile;
LogTextToScreen = new LogDelegate(log.LogTextToConsole);
LogTextToFile = new LogDelegate(log.LogTextToFile);

LogDelegate multiLog = LogTextToScreen + LogTextToFile;

multiLog("ExFour"!);

// Example Five - Passing a Delegate as a Parameter
static void LogText(LogDelegate log, string text)
{
    log(text);
}

LogText(multiLog, "ExFive");


