namespace SymbolicDifferentiation.Visitors;

public class AtomVisitor : MainVisitor
{
    public override string VisitAtomVar(DiffGrammarParser.AtomVarContext context)
    {
        return "1";
    }

    public override string VisitAtomConst(DiffGrammarParser.AtomConstContext context)
    {
        return "0";
    }

    public override string VisitAtomParenExpr(DiffGrammarParser.AtomParenExprContext context)
    {
        return "(" + context.expr().Accept(ExprVis) + ")";
    }

    public override string VisitAtomNum(DiffGrammarParser.AtomNumContext context)
    {
        return "0";
    }
}