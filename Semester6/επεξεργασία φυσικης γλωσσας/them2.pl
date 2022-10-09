digit(Value)--> [Value).

digit(0000) --> [0000]. 

digit(0001) --> [0001]. 

digit(0010) --> [0010]. 

digit(0011) --> [0011]. 

digit(0100) --> [0100]. 

digit(0101) --> [0101]. 

digit(0110) --> [0110]. 

digit(0111) --> [0111]. 

digit(1000) --> [1000]. 

digit(1001) --> [1001].

number(X) --> digit(X). 

expression(Value) --> number(Value).

expression(Value) --> number(X), [+], expression(V),	
{Value is X+V}.

expression(Value) --> number(X), [-], expression(V),	
{Value is X-V}.

expression(Value) --> number(X), [*], expression(V),	
{Value is X*V}.

expression(Value) -->number(X), [/], expression(V),	
{V/=0, Value is X/V}.

left_parenthesis --> ['(']. 

right_parenthesis --> [')'].

arithmetic_operator --> [+]. 

arithmetic_operator --> [-]. 

arithmetic_operator --> [*]. 

arithmetic_operator --> [/].

expression(Value) --> left_parenthesis, expression(Value), right_parenthesis.

expression(Value)  --> expression(Value),arithmetic_operator,expression(Value).

expression(V,[]).


number(A) --> digit(X), number(B),  

{numberofdigits(B,N), A is X*2^N+B}. 

numberofdigits(Y,1) :- Z is Y/2, Z<1. 

numberofdigits(Y,N) :-  

Z is (Y - mod(Y,2))/2, 

numberofdigits(Z,N1),  

N is N1+1. 