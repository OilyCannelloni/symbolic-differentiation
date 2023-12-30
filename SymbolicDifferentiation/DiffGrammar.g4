grammar DiffGrammar;


expr
    : term (PLUS | MINUS) expr #ExprSum
    | term #ExprTerm
    ;

term
    : factor TIMES term #TermTimesFactor
    | factor DIV term #TermDivFactor
    | factor #TermFactor
    ;

factor
    : atom POW atom #FactPow
    | atom #FactAtom
    ;
    
atom
    : VAR #AtomVar
    | NUM #AtomNum
    | LPAREN const RPAREN #AtomConst
    | LPAREN expr RPAREN #AtomParenExpr
    ;

    
const
    : const (PLUS | MINUS | TIMES | DIV | POW) const #ConstOp
    | LPAREN const RPAREN #ConstParen
    | NUM #ConstAtom
    ;

fragment E
    : 'E'
    | 'e'
    ;

fragment SIGN
    : '+'
    | '-'
    ;
    
NUM
    : ('0' .. '9')+ ('.' ('0' .. '9')+)?
    ;

VAR
    : 'x'
    ;

LPAREN
    : '('
    ;

RPAREN
    : ')'
    ;

PLUS
    : '+'
    ;

MINUS
    : '-'
    ;

TIMES
    : '*'
    ;

DIV
    : '/'
    ;

POINT
    : '.'
    ;

POW
    : '^'
    ;

WS
    : [ \r\n\t]+ -> skip
    ;