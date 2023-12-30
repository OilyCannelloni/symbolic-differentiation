namespace SymbolicDifferentiation.Simplification;

public class TermSimplifier : MainSimplifier
{
    public override string VisitTermFactor(DiffGrammarParser.TermFactorContext context)
    {
        return context.factor().Accept(FactorSimplifier);
    }

    public override string VisitTermDivFactor(DiffGrammarParser.TermDivFactorContext context)
    {
        string l = context.factor().Accept(FactorSimplifier);
        string r = context.term().Accept(this);

        if (IsOne(r))
            return l;
        if (IsZero(r))
            throw new DivideByZeroException();
        if (IsEqual(l, r))
            return "1";

        return $"{l}/{r}";
    }

    public override string VisitTermTimesFactor(DiffGrammarParser.TermTimesFactorContext context)
    {
        string l = context.factor().Accept(FactorSimplifier);
        string r = context.term().Accept(this);

        if (IsZero(l) || IsZero(r))
            return "0";
        if (IsOne(l))
            return r;
        if (IsOne(r))
            return l;
        return $"{l}*{r}";
    }
}