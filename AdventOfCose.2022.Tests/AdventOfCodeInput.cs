using System.Reflection;

namespace AdventOfCode2022.Tests;

public static class AdventOfCodeInput
{
    public static string FetchInput(string fileName)
    {
        var assembly = Assembly.GetExecutingAssembly();
        string resourceName = assembly.GetManifestResourceNames().Single(str => str.EndsWith(fileName));

        using Stream? stream = assembly.GetManifestResourceStream(resourceName);
        using StreamReader reader = new StreamReader(stream);
        string result = reader.ReadToEnd();

        return result;
    }
}