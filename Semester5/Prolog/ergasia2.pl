precede_list([X], [X|_]).
precede_list([X],[H|T]):-
 X=:=H,
 precede_list([X],T).
precede_list([X,H|T1], [X|T2]) :-
    precede_list([H|T1], T2).
precede_list([X,H|T1], [Y|T2]) :-
    X =:= Y,
    precede_list([X,H|T1], T2).