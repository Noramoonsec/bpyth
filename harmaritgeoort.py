sayilar=[]
def aritort(sayilar):
    ort= sum(sayilar)/len(sayilar)
    print(ort)
def geoort(sayilar):
    carpim=1
    for sayi in sayilar:
        carpim=carpim*sayi
    ort=(carpim)**1/len(sayilar)
    print(ort)
def harmort(sayilar):
    toplam=0
    for sayi in sayilar:
        toplam+=1/sayi
    ort=len(sayilar)/toplam
    print(ort)

for x in range(5):
    sayi=int(input("sayi giriniz: "))
    sayilar.append(sayi)
aritort(sayilar)
geoort(sayilar)
harmort(sayilar)

    