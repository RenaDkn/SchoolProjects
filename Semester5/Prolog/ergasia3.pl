/*Υπάρχουν πέντε διαδοχικά γραφεία,καθε ενα με διαφορετικο χρώμα.
Ο ανθρωπος που εργάζεται σε κάθε γραφείο είναι απο διαφορετικο τμήμα,
έχει διαφορετικο τύπο υπολογιστή,πίνει διαφορετικο ποτό και έχει διαφορετικο κινητό.
Ποιος εργαζόμενος έχει windows xp laptop?Ποιός εργζόμενος πίνει νερό?

	 1)Ο εργαζόμενος απο το τμήμα πληροφορικής(computer_science) έχει το κόκκινο(red) γραφείο.
	 2) Ο εργαζόμενος απο το τμήμα οργάνωσης και διοίκησης(organization_administration) έχει macbook pro(macbook_pro).
	 3) Ο εργαζόμενος στο πράσινο γραφείο(green) πίνει καφέ(coffee).
	 4) Ο εργαζόμενος απο το οικονομικό τμήμα(economics) πίνει τσάι(tea).
	 5) Το πράσινο γραφείο(green) είναι δεξιά του μπέζ γραφείου(beige).
	 6) Ο εργαζόμενος που έχει iphone έχει και macbook air (macbook_air).
	 7) Ο εργαζόμενος που έχει blackberry έχει το κίτρινο γραφείο (yellow).
	 8) Γάλα πίνει ο εργαζόμενος στο μεσαίο γραφείο.
	 9) Ο εργαζόμενος απο το τμήμα διεθνών σχέσεων(international_relations) έχει το πρώτο γραφείο(απο αριστερά).
	10) Ο εργαζόμενος που έχει nokia έχει το γραφείο που βρίσκεται διπλα απο το γραφείο του εργαζόμενου με το netbook.
	11) Ο εργαζόμενος με το blackberry βρίσκεται διπλα αποτον εργαζόμενο που έχει windows7 laptop (windows7).
	12) Ο εργαζόμενος που έχει android πίνει πορτοκαλάδα(juice).
	13) Ο εργαζόμενος απο το τμήμα προμηθειών έχει ericsson.
	14) Ο εργαζόμενος απο το τμήμα διεθνών σχέσεων(international_relations) έχει γραφείο που είναι διπλα στο μπλε γραφείο(blue). 

*/

adjacent(A, B, List) :- nextto(A, B, List); nextto(B, A, List).

offices(WaterDrinker, WindowsXpOwner) :-
	
	length(Of, 5),                                            
	member(o(computer_science,red,_,_,_), Of),                          % 1
	member(o(organization_administration,_,macbook_pro,_,_), Of),       % 2
	member(o(_,green,_,coffee,_), Of),                                  % 3
	member(o(economics,_,_,tea,_), Of),                                 %  4
	nextto(o(_,green,_,_,_), o(_,beige,_,_,_), Of),                       %  5
	member(o(_,_,macbook_air,_,iphone), Of),                            %  6
	member(o(_,yellow,_,_,blackberry), Of),                             %  7
	nth1(3, Of, o(_, _, _, milk, _)),                                    %  8
	nth1(1, Of, o(international_relations,_, _, _, _)),                        %  9
	adjacent(o(_,_,_,_,nokia), o(_,_,netbook,_,_), Of),                     % 10
	adjacent(o(_,_,_,_,blackberry), o(_,_,windows7,_,_), Of),      		    % 11
	member(o(_,_,_,juice,android), Of),                                 % 12
	member(o(supplies,_,_,_,ericsson), Of),                             % 13
	adjacent(o(international_relations,_,_,_,_), o(_,blue,_,_,_), Of),      % 14
	member(o(WaterDrinker,_,_, water, _), Of),                        
	member(o(WindowsXpOwner,_, windows_xp,_,_), Of).  

