namespace SymbolicDifferentiation.Visitors;

public class FactorVisitor : MainVisitor
{
    public override string VisitFactAtom(DiffGrammarParser.FactAtomContext context)
    {
        return context.atom().Accept(AtomVis);
    }

    public override string VisitFactPow(DiffGrammarParser.FactPowContext context)
    {
        var baze = context.atom(0);
        var power = context.atom(1);

        bool baseConst = baze.Accept(CheckConstVis);
        bool powerConst = power.Accept(CheckConstVis);

        switch (baseConst, powerConst)
        {
            case (true, true):
                return "0";
            case (true, false):
                return context.GetText() + "*ln(" + baze.GetText() + ")" + "*" + power.Accept(AtomVis);
            case (false, true):
                try
                {
                    int powInt = int.Parse(power.GetText());
                    return power.GetText() + "*" + baze.GetText() + "^" + (powInt - 1) + "*" + baze.Accept(AtomVis);
                }
                catch (FormatException e)
                {
                    return power.GetText() + "*" + baze.GetText() + "^" + "(" + power.GetText() + "-" + 1 + ")" + "*" + baze.Accept(AtomVis);
                }
            case (false, false):
                throw new NotImplementedException();
        }
    }
}