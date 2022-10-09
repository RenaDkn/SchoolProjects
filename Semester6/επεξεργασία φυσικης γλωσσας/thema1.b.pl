s(s(NP,VP))  --> np(NP), vp(VP). 
pp(pp(P,NP) --> prep(P), np(NP).
np(np(D,N))  --> det(D), noun(N). 
vp(vp(V,NP,PP)) --> verb(V), np(NP), pp(PP).
det(det(the)) --> [the]. 
verb(verb(brought)) --> [brought].
prep(prep(to)) --> [to]. 
noun(noun(waiter)) --> [waiter]. 
noun(noun(meal)) --> [meal]. 
noun(noun(table)) --> [table].


