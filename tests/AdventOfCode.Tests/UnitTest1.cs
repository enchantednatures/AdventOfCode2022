using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace AdventOfCode.Tests;

public class Tests
{
    private string _currentDirectory;

    [SetUp]
    public void Setup()
    {
        _currentDirectory = Directory.GetCurrentDirectory();
    }

    [Test]
    public void Test1()
    {
        // string filePath = Current
        string[] lines = File.ReadAllLines($"{_currentDirectory}/inputs/input.txt");
        var serializer = new InputDeserializer();
        var result = serializer.DeserializeLines(lines);
        // Console.WriteLine(JsonSerializer.Serialize(result));
        var maxFinder = new MaxFinder();
        var max = maxFinder.GnomeWithMax(result);
        Console.WriteLine(max);
    }

    [Test]
    public void Day2()
    {
        string[] lines = File.ReadAllLines($"{_currentDirectory}/inputs/day2_prod.txt");
        var engine = new TournamentEngine(lines);
        var score = engine.CalcScore();
        Console.WriteLine($"{score}");
    }
}