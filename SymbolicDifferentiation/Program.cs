// See https://aka.ms/new-console-template for more information

using Antlr4.Runtime;
using SymbolicDifferentiation;
using SymbolicDifferentiation.Simplification;
using SymbolicDifferentiation.Visitors;

const string input = "x^2 + 2*x^2";



var differentiator = new ExprDifferentiator();
var simplifier = new ExprSimplifier();

var tree = BuildTree(input);
string simplified = simplifier.Visit(tree);
tree = BuildTree(simplified);
string diff = differentiator.Visit(tree);
tree = BuildTree(diff);
string simplifiedDiff = simplifier.Visit(tree);

Console.WriteLine(input);
Console.WriteLine(simplified);
Console.WriteLine(diff);
Console.WriteLine(simplifiedDiff);
return;



DiffGrammarParser.ExprContext BuildTree(string s)
{
    var inputStream = new AntlrInputStream(s);
    var lexer = new DiffGrammarLexer(inputStream);
    var tokenStream = new CommonTokenStream(lexer);
    var parser = new DiffGrammarParser(tokenStream)
    {
        BuildParseTree = true
    };

    parser.RemoveErrorListeners();
    parser.AddErrorListener(new BaseErrorListener());
    return parser.expr();
}
