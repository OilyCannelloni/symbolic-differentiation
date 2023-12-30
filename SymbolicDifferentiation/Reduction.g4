grammar Reduction;

expr
    : term+
    ;
    
term
    : (PLUS | MINUS)? literal (TIMES literal)*
    ;
    
    
literal
    : NUM
    | VAR
    | LPAREN expr RPAREN
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