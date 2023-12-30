//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\barte\RiderProjects\SymbolicDifferentiation\SymbolicDifferentiation\DiffGrammar.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace SymbolicDifferentiation {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="DiffGrammarParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IDiffGrammarVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>ConstOp</c>
	/// labeled alternative in <see cref="DiffGrammarParser.const"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstOp([NotNull] DiffGrammarParser.ConstOpContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ConstAtom</c>
	/// labeled alternative in <see cref="DiffGrammarParser.const"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstAtom([NotNull] DiffGrammarParser.ConstAtomContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ConstParen</c>
	/// labeled alternative in <see cref="DiffGrammarParser.const"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstParen([NotNull] DiffGrammarParser.ConstParenContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ExprSum</c>
	/// labeled alternative in <see cref="DiffGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprSum([NotNull] DiffGrammarParser.ExprSumContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ExprTerm</c>
	/// labeled alternative in <see cref="DiffGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprTerm([NotNull] DiffGrammarParser.ExprTermContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>TermFactor</c>
	/// labeled alternative in <see cref="DiffGrammarParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTermFactor([NotNull] DiffGrammarParser.TermFactorContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>TermDivFactor</c>
	/// labeled alternative in <see cref="DiffGrammarParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTermDivFactor([NotNull] DiffGrammarParser.TermDivFactorContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>TermTimesFactor</c>
	/// labeled alternative in <see cref="DiffGrammarParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTermTimesFactor([NotNull] DiffGrammarParser.TermTimesFactorContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>FactAtom</c>
	/// labeled alternative in <see cref="DiffGrammarParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFactAtom([NotNull] DiffGrammarParser.FactAtomContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>FactPow</c>
	/// labeled alternative in <see cref="DiffGrammarParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFactPow([NotNull] DiffGrammarParser.FactPowContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AtomVar</c>
	/// labeled alternative in <see cref="DiffGrammarParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAtomVar([NotNull] DiffGrammarParser.AtomVarContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AtomConst</c>
	/// labeled alternative in <see cref="DiffGrammarParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAtomConst([NotNull] DiffGrammarParser.AtomConstContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AtomNum</c>
	/// labeled alternative in <see cref="DiffGrammarParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAtomNum([NotNull] DiffGrammarParser.AtomNumContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AtomParenExpr</c>
	/// labeled alternative in <see cref="DiffGrammarParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAtomParenExpr([NotNull] DiffGrammarParser.AtomParenExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DiffGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpr([NotNull] DiffGrammarParser.ExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DiffGrammarParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTerm([NotNull] DiffGrammarParser.TermContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DiffGrammarParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFactor([NotNull] DiffGrammarParser.FactorContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DiffGrammarParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAtom([NotNull] DiffGrammarParser.AtomContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DiffGrammarParser.const"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConst([NotNull] DiffGrammarParser.ConstContext context);
}
} // namespace SymbolicDifferentiation
