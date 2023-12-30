namespace SymbolicDifferentiation.Visitors;

public class CheckConstVisitor : DiffGrammarBaseVisitor<bool>
{
    public override bool VisitAtomVar(DiffGrammarParser.AtomVarContext context)
    {
        return false;
    }

    public override bool VisitAtomConst(DiffGrammarParser.AtomConstContext context)
    {
        return true;
    }

    public override bool VisitAtomParenExpr(DiffGrammarParser.AtomParenExprContext context)
    {
        return false;
    }

    public override bool VisitAtomNum(DiffGrammarParser.AtomNumContext context)
    {
        return true;
    }
}