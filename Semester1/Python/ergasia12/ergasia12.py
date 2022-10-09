#Ergasia12
from datetime import datetime #vivliothiki ya na vriskume thn trexwn wra

hmerominia=input("Δώσε ημερομηνία σε μορφή:HH/MM/EEEE")
lista=hmerominia.split("/")
if len(lista)==3:
    while isinstance(lista[0],int) and isinstance(lista[1],int) and isinstance(lista[3],int):
        print("Σε κάποια τιμή εγίνε λάθος")
        hmerominia=input("Δώσε ημερομηνία σε μορφή:HH/MM/EEEE")
        lista=hmerominia.split("/")
    trexon=datetime.now().strftime("%d/%m/%Y/%H/%M/%S")
    xrhsths=datetime(int(lista[2]),int(lista[1]),int(lista[0]),00,00,00).strftime("%d/%m/%Y/%H/%M/%S")
    
    #mines=(date(minmeta)-date(xrhsths))
    date_format = "%d/%m/%Y/%H/%M/%S"
    a = datetime.strptime(trexon, date_format)
    b = datetime.strptime(xrhsths, date_format)
    d = b - a
    
    days=abs(d.days)
    
    x=str(d).split()
    if len(x)!=1:
        time=x[2].split(":")
        sec=int(time[1])*60
        sec+=int(time[2])
        print (days,"/",time[0],"/",sec)
    else:
        time=x[0].split(":")
        sec=int(time[1])*60
        sec+=int(time[2])
        print("0/",time[0],"/",sec)
    lista[1]=int(lista[1])
    lista[0]=int(lista[0])
    if lista[1]==1 or lista[1]==3 or lista[1]==5 or lista[1]==7 or lista[1]==8 or lista[1]==10 or lista[1]==12:
        print ("O mhnas pou dothike exei 31 hmeres")
    elif lista[1]==2:
        if lista[0]%4!=0:
            print ("O mhnas pou dothike exei 28 hmeres")
        elif lista[0]%100!=0:
            print ("O mhnas pou dothike exei 29 hmeres")
        elif  lista[0]%400!=0:
            print ("O mhnas pou dothike exei 28 hmeres")
        else:
            print ("O mhnas pou dothike exei 29 hmeres")
    else:
        print ("O mhnas pou dothike exei 30 hmeres")
else:
    print("Kati leipei!Jana trexto!-.-")

    

