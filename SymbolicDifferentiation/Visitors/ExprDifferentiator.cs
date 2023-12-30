namespace SymbolicDifferentiation.Visitors;

public class ExprDifferentiator : MainVisitor
{
    public override string VisitExprSum(DiffGrammarParser.ExprSumContext context)
    {
        return context.term().Accept(TermVis) + "+" + context.expr().Accept(this);
    }

    public override string VisitExprTerm(DiffGrammarParser.ExprTermContext context)
    {
        return context.term().Accept(TermVis);
    }
}