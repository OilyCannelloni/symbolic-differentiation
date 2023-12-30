//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\barte\RiderProjects\SymbolicDifferentiation\SymbolicDifferentiation\Reduction.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace SymbolicDifferentiation {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class ReductionParser : Parser {
	public const int
		NUM=1, VAR=2, LPAREN=3, RPAREN=4, PLUS=5, MINUS=6, TIMES=7, DIV=8, POINT=9, 
		POW=10, WS=11;
	public const int
		RULE_expr = 0, RULE_term = 1, RULE_literal = 2;
	public static readonly string[] ruleNames = {
		"expr", "term", "literal"
	};

	private static readonly string[] _LiteralNames = {
		null, null, "'x'", "'('", "')'", "'+'", "'-'", "'*'", "'/'", "'.'", "'^'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "NUM", "VAR", "LPAREN", "RPAREN", "PLUS", "MINUS", "TIMES", "DIV", 
		"POINT", "POW", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Reduction.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public ReductionParser(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class ExprContext : ParserRuleContext {
		public TermContext[] term() {
			return GetRuleContexts<TermContext>();
		}
		public TermContext term(int i) {
			return GetRuleContext<TermContext>(i);
		}
		public ExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expr; } }
		public override void EnterRule(IParseTreeListener listener) {
			IReductionListener typedListener = listener as IReductionListener;
			if (typedListener != null) typedListener.EnterExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IReductionListener typedListener = listener as IReductionListener;
			if (typedListener != null) typedListener.ExitExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IReductionVisitor<TResult> typedVisitor = visitor as IReductionVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExpr(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExprContext expr() {
		ExprContext _localctx = new ExprContext(_ctx, State);
		EnterRule(_localctx, 0, RULE_expr);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 7;
			_errHandler.Sync(this);
			_la = _input.La(1);
			do {
				{
				{
				State = 6; term();
				}
				}
				State = 9;
				_errHandler.Sync(this);
				_la = _input.La(1);
			} while ( (((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << NUM) | (1L << VAR) | (1L << LPAREN) | (1L << PLUS) | (1L << MINUS))) != 0) );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TermContext : ParserRuleContext {
		public LiteralContext[] literal() {
			return GetRuleContexts<LiteralContext>();
		}
		public LiteralContext literal(int i) {
			return GetRuleContext<LiteralContext>(i);
		}
		public ITerminalNode[] TIMES() { return GetTokens(ReductionParser.TIMES); }
		public ITerminalNode TIMES(int i) {
			return GetToken(ReductionParser.TIMES, i);
		}
		public ITerminalNode PLUS() { return GetToken(ReductionParser.PLUS, 0); }
		public ITerminalNode MINUS() { return GetToken(ReductionParser.MINUS, 0); }
		public TermContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_term; } }
		public override void EnterRule(IParseTreeListener listener) {
			IReductionListener typedListener = listener as IReductionListener;
			if (typedListener != null) typedListener.EnterTerm(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IReductionListener typedListener = listener as IReductionListener;
			if (typedListener != null) typedListener.ExitTerm(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IReductionVisitor<TResult> typedVisitor = visitor as IReductionVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTerm(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TermContext term() {
		TermContext _localctx = new TermContext(_ctx, State);
		EnterRule(_localctx, 2, RULE_term);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 12;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==PLUS || _la==MINUS) {
				{
				State = 11;
				_la = _input.La(1);
				if ( !(_la==PLUS || _la==MINUS) ) {
				_errHandler.RecoverInline(this);
				} else {
					if (_input.La(1) == TokenConstants.Eof) {
						matchedEOF = true;
					}

					_errHandler.ReportMatch(this);
					Consume();
				}
				}
			}

			State = 14; literal();
			State = 19;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==TIMES) {
				{
				{
				State = 15; Match(TIMES);
				State = 16; literal();
				}
				}
				State = 21;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class LiteralContext : ParserRuleContext {
		public ITerminalNode NUM() { return GetToken(ReductionParser.NUM, 0); }
		public ITerminalNode VAR() { return GetToken(ReductionParser.VAR, 0); }
		public ITerminalNode LPAREN() { return GetToken(ReductionParser.LPAREN, 0); }
		public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public ITerminalNode RPAREN() { return GetToken(ReductionParser.RPAREN, 0); }
		public LiteralContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_literal; } }
		public override void EnterRule(IParseTreeListener listener) {
			IReductionListener typedListener = listener as IReductionListener;
			if (typedListener != null) typedListener.EnterLiteral(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IReductionListener typedListener = listener as IReductionListener;
			if (typedListener != null) typedListener.ExitLiteral(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IReductionVisitor<TResult> typedVisitor = visitor as IReductionVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLiteral(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public LiteralContext literal() {
		LiteralContext _localctx = new LiteralContext(_ctx, State);
		EnterRule(_localctx, 4, RULE_literal);
		try {
			State = 28;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case NUM:
				EnterOuterAlt(_localctx, 1);
				{
				State = 22; Match(NUM);
				}
				break;
			case VAR:
				EnterOuterAlt(_localctx, 2);
				{
				State = 23; Match(VAR);
				}
				break;
			case LPAREN:
				EnterOuterAlt(_localctx, 3);
				{
				State = 24; Match(LPAREN);
				State = 25; expr();
				State = 26; Match(RPAREN);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3\r!\x4\x2\t\x2\x4"+
		"\x3\t\x3\x4\x4\t\x4\x3\x2\x6\x2\n\n\x2\r\x2\xE\x2\v\x3\x3\x5\x3\xF\n\x3"+
		"\x3\x3\x3\x3\x3\x3\a\x3\x14\n\x3\f\x3\xE\x3\x17\v\x3\x3\x4\x3\x4\x3\x4"+
		"\x3\x4\x3\x4\x3\x4\x5\x4\x1F\n\x4\x3\x4\x2\x2\x2\x5\x2\x2\x4\x2\x6\x2"+
		"\x2\x3\x3\x2\a\b\"\x2\t\x3\x2\x2\x2\x4\xE\x3\x2\x2\x2\x6\x1E\x3\x2\x2"+
		"\x2\b\n\x5\x4\x3\x2\t\b\x3\x2\x2\x2\n\v\x3\x2\x2\x2\v\t\x3\x2\x2\x2\v"+
		"\f\x3\x2\x2\x2\f\x3\x3\x2\x2\x2\r\xF\t\x2\x2\x2\xE\r\x3\x2\x2\x2\xE\xF"+
		"\x3\x2\x2\x2\xF\x10\x3\x2\x2\x2\x10\x15\x5\x6\x4\x2\x11\x12\a\t\x2\x2"+
		"\x12\x14\x5\x6\x4\x2\x13\x11\x3\x2\x2\x2\x14\x17\x3\x2\x2\x2\x15\x13\x3"+
		"\x2\x2\x2\x15\x16\x3\x2\x2\x2\x16\x5\x3\x2\x2\x2\x17\x15\x3\x2\x2\x2\x18"+
		"\x1F\a\x3\x2\x2\x19\x1F\a\x4\x2\x2\x1A\x1B\a\x5\x2\x2\x1B\x1C\x5\x2\x2"+
		"\x2\x1C\x1D\a\x6\x2\x2\x1D\x1F\x3\x2\x2\x2\x1E\x18\x3\x2\x2\x2\x1E\x19"+
		"\x3\x2\x2\x2\x1E\x1A\x3\x2\x2\x2\x1F\a\x3\x2\x2\x2\x6\v\xE\x15\x1E";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace SymbolicDifferentiation