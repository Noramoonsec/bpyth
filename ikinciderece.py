def kok(a,b,c):
    x= (-b - (((b**2)-4*a*c)**(1/2)))/(2*a)
    x2=(-b + (((b**2)-4*a*c)**(1/2)))/(2*a)
    print(x,x2)
a = int(input("sayi gir: "))
b = int(input("sayi gir: "))
c = int(input("sayi gir: "))
kok(a,b,c)