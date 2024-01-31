namespace FIRSTPrinciplesProj;

public class IndependentExp
{
    public List<string> Seprator(string orderBy)
    {
        var sep = orderBy.Split(',');

        return sep.ToList();
    }
}
