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
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IDiffGrammarVisitor{Result}"/>,
/// which can be extended to create a visitor which only needs to handle a subset
/// of the available methods.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class DiffGrammarBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, IDiffGrammarVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>ConstOp</c>
	/// labeled alternative in <see cref="DiffGrammarParser.const"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitConstOp([NotNull] DiffGrammarParser.ConstOpContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ConstAtom</c>
	/// labeled alternative in <see cref="DiffGrammarParser.const"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitConstAtom([NotNull] DiffGrammarParser.ConstAtomContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ConstParen</c>
	/// labeled alternative in <see cref="DiffGrammarParser.const"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitConstParen([NotNull] DiffGrammarParser.ConstParenContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ExprSum</c>
	/// labeled alternative in <see cref="DiffGrammarParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExprSum([NotNull] DiffGrammarParser.ExprSumContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ExprTerm</c>
	/// labeled alternative in <see cref="DiffGrammarParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExprTerm([NotNull] DiffGrammarParser.ExprTermContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>TermFactor</c>
	/// labeled alternative in <see cref="DiffGrammarParser.term"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTermFactor([NotNull] DiffGrammarParser.TermFactorContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>TermDivFactor</c>
	/// labeled alternative in <see cref="DiffGrammarParser.term"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTermDivFactor([NotNull] DiffGrammarParser.TermDivFactorContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>TermTimesFactor</c>
	/// labeled alternative in <see cref="DiffGrammarParser.term"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTermTimesFactor([NotNull] DiffGrammarParser.TermTimesFactorContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>FactAtom</c>
	/// labeled alternative in <see cref="DiffGrammarParser.factor"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFactAtom([NotNull] DiffGrammarParser.FactAtomContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>FactPow</c>
	/// labeled alternative in <see cref="DiffGrammarParser.factor"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFactPow([NotNull] DiffGrammarParser.FactPowContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>AtomVar</c>
	/// labeled alternative in <see cref="DiffGrammarParser.atom"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAtomVar([NotNull] DiffGrammarParser.AtomVarContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>AtomConst</c>
	/// labeled alternative in <see cref="DiffGrammarParser.atom"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAtomConst([NotNull] DiffGrammarParser.AtomConstContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>AtomNum</c>
	/// labeled alternative in <see cref="DiffGrammarParser.atom"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAtomNum([NotNull] DiffGrammarParser.AtomNumContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>AtomParenExpr</c>
	/// labeled alternative in <see cref="DiffGrammarParser.atom"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAtomParenExpr([NotNull] DiffGrammarParser.AtomParenExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="DiffGrammarParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExpr([NotNull] DiffGrammarParser.ExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="DiffGrammarParser.term"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTerm([NotNull] DiffGrammarParser.TermContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="DiffGrammarParser.factor"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFactor([NotNull] DiffGrammarParser.FactorContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="DiffGrammarParser.atom"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAtom([NotNull] DiffGrammarParser.AtomContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="DiffGrammarParser.const"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitConst([NotNull] DiffGrammarParser.ConstContext context) { return VisitChildren(context); }
}
} // namespace SymbolicDifferentiation
