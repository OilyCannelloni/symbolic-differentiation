namespace SymbolicDifferentiation.Simplification;

public class ConstSimplifier : DiffGrammarBaseVisitor<double?>
{
    private int? RoundDouble(double x)
    {
        if (Math.Abs(Math.Round(x) - x) < 0.0001)
            return (int) Math.Floor(x + 0.0002);
        return null;
    }

    public override double? VisitConstOp(DiffGrammarParser.ConstOpContext context)
    {
        if (context.PLUS() != null)
            return context.@const(0).Accept(this) + context.@const(1).Accept(this);
        if (context.MINUS() != null)
            return context.@const(0).Accept(this) - context.@const(1).Accept(this);
        if (context.TIMES() != null)
            return context.@const(0).Accept(this) * context.@const(1).Accept(this);
        if (context.DIV() != null)
            return context.@const(0).Accept(this) / context.@const(1).Accept(this);
        if (context.POW() != null)
        {
            return Math.Pow(context.@const(0).Accept(this) ?? 1, context.@const(1).Accept(this) ?? 1);
        }

        return 0.0;
    }

    public override double? VisitConstAtom(DiffGrammarParser.ConstAtomContext context)
    {
        return double.Parse(context.GetText());
    }

    public override double? VisitConstParen(DiffGrammarParser.ConstParenContext context)
    {
        return context.@const().Accept(this);
    }
}