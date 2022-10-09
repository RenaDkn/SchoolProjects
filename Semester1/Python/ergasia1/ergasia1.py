A=[]
fonie=["A","E","O","I","U","Y","a","e","o","i","u","y"]
inp=input("Dwse ena arxeio")
arx=open(inp,"r")
arxeio=arx.read()
lejeis=arxeio.split()
num=len(lejeis)
maxx=""
pos=0
for i in range(5):
    maxx=lejeis[0]
    for j in range(num):
        if len(maxx)< len(lejeis[j]):
            maxx=lejeis[j]
            pos=j


    maxx=""
    A.append(lejeis[pos])
    lejeis[pos]=""
    pos=0
print(A)
for i in A:
    r=""
    for j in range(len(i)):
        if i[j] not in fonie:
            r+=i[j]
    print (r[::-1])
