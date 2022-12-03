namespace AdventOfCode.Day3;

public class Backpack
{
    public Backpack(List<BackpackItem> frontCompartment, List<BackpackItem> rearCompartment)
    {
        FrontCompartment = frontCompartment;
        RearCompartment = rearCompartment;
    }

    public List<BackpackItem> FrontCompartment { get; }
    public List<BackpackItem> RearCompartment { get; }

    public BackpackItem? Overlap
    {
        get
        {
            return FrontCompartment
                .Where(e => RearCompartment.Select(bi => bi.Value).Contains(e.Value)).First();
        }
    }
}