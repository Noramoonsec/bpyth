def ucgen():
    a=int(input("kenar giriniz: "))
    b=int(input("kenar giriniz: "))
    c =int(input("taban giriniz: "))
    h= int(input("yükseklik giriniz: "))
    cevre=a+b+c
    alan=(c*h)/2
    print(f"üçgenin çevresi: {cevre}, üçgenin alanı: {alan}")
def kare ():
    a=int(input("uzunkenar giriniz: "))
    b=int(input("kısakenar giriniz: "))
    cevre=(2*a)+(2*b)
    alan=a*b
    print(f"kare çevresi: {cevre}, kare alanı: {alan}")
def daire():
    pi=3.14
    r=int(input("yaricap giriniz: "))
    alan=pi*(r**2)
    cevre=2*(pi*r)
    print(f"daire çevresi: {cevre}, daire alanı: {alan}")
secim=input("""lütfen seçiminizi yapın:
            1.üçgen 
            2. kare
            3. daire
            """ )
if secim=='1':
    ucgen()
elif secim =='2':
    kare()
elif secim=='3':
    daire()