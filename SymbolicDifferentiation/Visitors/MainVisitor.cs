// ReSharper disable InconsistentNaming
namespace SymbolicDifferentiation.Visitors;

public class MainVisitor : DiffGrammarBaseVisitor<string>
{
    protected static readonly ExprDifferentiator ExprVis = new();
    protected static readonly TermVisitor TermVis = new();
    protected static readonly FactorVisitor FactorVis = new();
    protected static readonly AtomVisitor AtomVis = new();
    protected static readonly ConstVisitor ConstVis = new();
    protected static readonly CheckConstVisitor CheckConstVis = new();
}