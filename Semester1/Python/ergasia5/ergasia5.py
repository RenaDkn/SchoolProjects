#ergasia 5
ep=input("Thelete na dwsete onoma arxeio? nai h oxi?")    #o xrhsths epilegei ean thelei na dwsi onoma arxeiou h na plhktrologisei keimeno
while ep!="nai" and ep!="oxi":                          #elegxos ean exi dwsei egkurh apadisi kai minima lathus ean exei dwsei akyrh
    ep=input("Lathos apadisi.Apadiste me nai h me oxi!Thelete na dwsete onoma arxeiou?")
if (ep=="nai"):                                          #elegxos ean edwse ap nai h oxi kai ean edwse nai anigi to arxeio, ean oxi zitaei apo thn xrhsth na plhktrologisi ena
         onom=input("Dwse onoma arxeiou")
         arxeio=open(onom,"r")
         print(arxeio)
         keimeno=arxeio.read()
else:
    keimeno=input("Grapse ena keimeno.") #diavazei keimeno apo plhktrologio
arxeio.close()
#vazw ola ta simvola  se mia lista se mia lista
unwxar=[".","!","@","#","$","%","^","&","*","(",")","_","-","=","+","{","}","[","]",";",":","'","<",">",",","?","/","~","`"]
num=["1","2","3","4","5","6","7","8","9","0"]
lista=keimeno.split()           #kanei to keimeno lista (xwrizi tis lejeis)
i=len(lista)#vriskei ton arithmo twn stixeiwn ths listas
newkeim="" #arxiki timi
for j in range(0,i,1) :
    a=" "
    b=" "
    x=lista[j]                   #pairnw ta stoixeia tis listas k ta apothikevw sthn metavliti
    meg=len(x)
    if x[-1] in unwxar:
        meg=meg-1
        a=x[-1]
        x=x[:-1]
    if x[0] in unwxar:
        meg=meg-1
        b=x[0]
        x=x[1:]
    arithmos=True
    for d in range (0,meg,1):
        if x[d] in num:
            arithmos=False
            d=meg  
    if (meg>3 and arithmos):                 #elegxei ean o arthmos twn xaraktirwn ein megaliteros apo 3eis
        y= x[0]                     #ekxwrume sto y to prwto gramma
        y=str(y)
        z= x[1:]              #ekxwrume sto z ola ta grammata ektos tu 1ou
        z=str(z)
        x= z+y+"ay"
    if a!=" ":
        newkeim+=" "+x+a
    elif b!=" ":
        newkeim+=" "+b+x
    else:
        newkeim+=" "+x
print(newkeim)#emfanizume to keimeno
new=open("neoarxeio.txt","w") #auto dimiurgei arxeioV ya n grapsume mesa
new.write(newkeim)
new.close()
