using AdventOfCode.Day2;
using AdventOfCode.Day3;

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
    public void Day1()
    {
        // string filePath = Current
        var lines = File.ReadAllLines($"{_currentDirectory}/inputs/input.txt");
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
        var lines = File.ReadAllLines($"{_currentDirectory}/inputs/day2_prod.txt");
        var engine = new TournamentEngine(lines);
        var score = engine.CalcScore();
        Console.WriteLine($"{score}");
    }

    [Test]
    public void Day3()
    {
        var lines = File.ReadAllLines($"{_currentDirectory}/inputs/day_3_prod.txt");
        var backpacks = BackpackFactory.Create(lines).ToList();
        // Console.WriteLine(JsonSerializer.Serialize(backpacks, new JsonSerializerOptions( ) {WriteIndented = true}));
        var overlap = backpacks.Select(e => e.Overlap);
        // Console.WriteLine(JsonSerializer.Serialize(overlap, new JsonSerializerOptions( ) {WriteIndented = true}));
        Console.WriteLine(overlap.Sum(e => e.Value.Priority));
    }
}