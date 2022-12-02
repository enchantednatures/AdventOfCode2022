namespace AdventOfCode;

public static class PlayReader
{

    public static Plays ReadInput(string input)
    {
        switch (input)
        {
            case "A":
            case "X":
                return Plays.Rock;
            case "B":
            case "Y":
                return Plays.Paper;
                
            case "C":
            case "Z":
                return Plays.Scissor;
            default:
                throw new Exception();
        }
    }
}