namespace SymbolicDifferentiation.Simplification;

public class ExprSimplifier : MainSimplifier
{
    public override string VisitExprSum(DiffGrammarParser.ExprSumContext context)
    {
        string l = context.term().Accept(TermSimplifier);
        string r = context.expr().Accept(this);
        string s = context.PLUS() == null ? "-" : "+";
        
        if (IsZero(l))
            return (s == "+" ? "" : s) + r;
        if (IsZero(r))
            return l;
        return $"{l}{s}{r}";
    }

    public override string VisitExprTerm(DiffGrammarParser.ExprTermContext context)
    {
        return context.term().Accept(TermSimplifier);
    }
}