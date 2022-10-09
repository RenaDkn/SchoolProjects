def askisi4():
    x=""
    inp=input("Dwse ena string")
    for i in inp:
        x+=str(ord(i))
    print(x)
    x=int(x)
    ap=False
    for j in range (2,x):
        if x%j==0:
            ap=True
    if ap:
        print("O arithmos den einai prwtos")
    else:
        print("O arithmos einai prwtos")
#Borei na argei ean o arithmos ein megalos
askisi4()
