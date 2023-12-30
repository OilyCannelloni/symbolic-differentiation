namespace SymbolicDifferentiation.Simplification;

public class MainSimplifier : DiffGrammarBaseVisitor<string>
{
    protected static readonly ExprSimplifier ExprSimplifier = new();
    protected static readonly TermSimplifier TermSimplifier = new();
    protected static readonly FactorSimplifier FactorSimplifier = new();
    protected static readonly AtomSimplifier AtomSimplifier = new();
    protected static readonly ConstSimplifier ConstSimplifier = new();
    
    private static readonly string[] Zeros = { "0", "(0)" };

    private static readonly string[] Ones = { "1", "(1)" };
    
    protected static bool IsZero(string a) => Zeros.Contains(a);
    protected static bool IsOne(string a) => Ones.Contains(a);
    protected static bool IsConst(string a) => !a.Contains('x');

    protected static bool IsEqual(string a, string b)
    {
        return a == b;
    }
}