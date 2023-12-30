namespace SymbolicDifferentiation.Visitors;

public class TermVisitor : MainVisitor
{
    public override string VisitTermFactor(DiffGrammarParser.TermFactorContext context)
    {
        return context.factor().Accept(FactorVis);
    }

    public override string VisitTermDivFactor(DiffGrammarParser.TermDivFactorContext context)
    {
        var u = context.factor();
        var d = context.term();
        return "(" + u.Accept(FactorVis) + "*" + d.GetText() + "-" + d.Accept(this) + "*" + u.GetText() + ")/(" +
               d.GetText() + ")^2";
    }

    public override string VisitTermTimesFactor(DiffGrammarParser.TermTimesFactorContext context)
    {
        var l = context.factor();
        var r = context.term();
        var dl = l.Accept(FactorVis);
        var dr = r.Accept(FactorVis);
        return dl + "*" + r.GetText() + "+" + dr + "*" + l.GetText();
    }
}