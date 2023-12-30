namespace SymbolicDifferentiation.Visitors;

public class ConstVisitor : DiffGrammarBaseVisitor<string>
{
    public override string VisitConst(DiffGrammarParser.ConstContext context)
    {
        return "0";
    }
}