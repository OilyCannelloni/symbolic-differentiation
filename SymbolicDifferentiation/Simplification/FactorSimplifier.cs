namespace SymbolicDifferentiation.Simplification;

public class FactorSimplifier : MainSimplifier
{
    public override string VisitFactAtom(DiffGrammarParser.FactAtomContext context)
    {
        return context.atom().Accept(AtomSimplifier);
    }

    public override string VisitFactPow(DiffGrammarParser.FactPowContext context)
    {
        string baze = context.atom(0).Accept(AtomSimplifier);
        string power = context.atom(1).Accept(AtomSimplifier);

        if (IsZero(baze))
            return "0";
        if (IsOne(baze))
            return "1";
        if (IsZero(power))
            return "1";
        if (IsOne(power))
            return baze;
        return $"{baze}^{power}";
    }
}