namespace SymbolicDifferentiation.Simplification;

public class AtomSimplifier : MainSimplifier
{
    private bool IsParExpr(string s)
    {
        var count = 0;
        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
                count++;
            if (s[i] == ')')
                count--;
            if (count == 0 && i < s.Length - 1)
                return false;
        }

        return count == 0;
    }
    
    private bool IsLiteral(string s)
    {
        return s.IndexOfAny("+-*/^()".ToCharArray()) == -1;
    }
    
    public override string VisitAtomVar(DiffGrammarParser.AtomVarContext context)
    {
        return "x";
    }

    public override string VisitAtomNum(DiffGrammarParser.AtomNumContext context)
    {
        return context.GetText();
    }

    public override string VisitAtomConst(DiffGrammarParser.AtomConstContext context)
    {
        return context.@const().Accept(ConstSimplifier).ToString() ?? "";
    }

    public override string VisitAtomParenExpr(DiffGrammarParser.AtomParenExprContext context)
    {
        string inner = context.expr().Accept(ExprSimplifier);
        if (IsParExpr(inner))
            return inner;
        if (IsLiteral(inner))
            return inner;
        return "(" + context.expr().Accept(ExprSimplifier) + ")";
    }
}