def gkontrol(gun): 
    while len(gun)!=2:
        gun=input("gün giriniz: ")
    while gun<="0" or gun>="32":
       gun=input("gün giriniz: ")
def aykontrol(ay): 
    while len(ay)!=2:
        ay=input("ay giriniz: ")
    while ay<="0" or ay>="13":
       ay=input("ay giriniz: ")
def yilkontrol(yil):
    while len(yil)!=4:
        yil = input("yil giriniz: ")
    while yil<="1940" or yil>="2023":
        yil = input("yil giriniz: ")

def islemler(gun,ay,yil):
    toplam=int(gun)+int(ay)+int(yil[0]+yil[1])+int(yil[2] + yil[3])

    if toplam > 21: toplam=toplam%22
    return toplam

def aciklamayaz(aciklama):
    if toplam==0: 
        aciklama==print("""0 – Joker: Riskleri alma, açık fikirlilik, içindeki sesi dinleme.""")
    if toplam==1: 
        aciklama==print("""I – Büyücü: Yetenek, özgüven, yaratıcı olma, beceri,""")
    if toplam==2: 
        aciklama==print("""II – Azize: Oluşuna bırakabilme ve sezgisel güç.""")
    if toplam==3: 
        aciklama==print("""III – Kraliçe: Dişil güç ve bilgelik, yenilik, güzellik, doğanın gücü.""")
    if toplam==4: 
        aciklama==print("""III – Kraliçe: Dişil güç ve bilgelik, yenilik, güzellik, doğanın gücü.""")
    if toplam==5: 
        aciklama==print("""V – Aziz: Erdem, güven, maneviyat, anlamsal arayış.""")
    if toplam==6: 
        aciklama==print("""VI – Aşıklar: Duygusal verilen karar, kendini sevme, yol ayrımı.""")
    if toplam==7: 
        aciklama==print("""VII – Savaş Arabası: Bilinç kazanma, hedefe yönelme, deneyim kazanma, zorlukların ve çelişkilerin üstesinden gelme.""")
    if toplam==8: 
        aciklama==print("""VIII – Güç: Arzu, tutku, öz farkındalık, hayvansal doğamızla uzlaşma.""")
    if toplam==9: 
        aciklama==print("""IX – Ermiş: İç dönme, dış etkenlerden soyutlanma, içsel huzur, kendini bulma.""")
    if toplam==10: 
        aciklama==print("""X – Kader Çarkı: Kendi hayatının sorumluluğunu üstlenme, büyüme, olgunlaşma, yolunda gitmeyen olaylar ve durumlar.""")
    if toplam==11: 
        aciklama==print("""XI – Adalet: Denge, dürüstlük, objektif bakış, adalet.""")
    if toplam==12: 
        aciklama==print("""XII – Asılmış Adam: Yeni bir görüş edinme, yeni görüşü kazanmak için eskisini feda etme, zorunlu dinlenme, yeniye teslim olma.""")
    if toplam==13: 
        aciklama==print("""XIII – Ölüm: Eskinin sona ermesi ve yeninin doğuşu, yaşamın devamlılığı, ayrılık.""")
    if toplam==14: 
        aciklama==print("""XIV – Denge: Denge, çevreyle uzlaşma, uyum, kişinin kendisiyle barışması, kararlılık.""")
    if toplam==15: 
        aciklama==print("""XV – Şeytan: Kişinin kendisyle yüzleşmesi, bağımlılık, maddi güce bağımlı olma meyletme, iyi niyet yoksunluğu.""")
    if toplam==16: 
        aciklama==print("""XVI – Yıkılan Kule: Eski güvendiğimiz şeylerin yıkılması ve yeni için yer açılması. Bilinir olandan özgürleşmek, öz farkındalık.""")
    if toplam==17: 
        aciklama==print("""XVII – Yıldız: Beklenti, umut, öteyi kavrayış, kendine güven, yaşam enerjisi.""")
    if toplam==18: 
        aciklama==print("""XVIII – Ay: Umutsuzluk, belirsizlik, endişe, korku, kabus, iç karartıcı öz seziler, bilinmeyenle yüzleşme.""")
    if toplam==19: 
        aciklama==print("""XIX – Güneş: İyimserlik, sevecenlik, başarı, yaşama sevinci, yaratıcılık, öz güven.""")
    if toplam==10: 
        aciklama==print("""XX – Mahkeme: Kendini bulma, özgürleşme, umut tohumlarının yeşermesi, kurtuluş, bilincin uyanışı, değişim sürecinin olumlu tamamlanması.""")
    if toplam==21: 
        aciklama==print("""XXI – Dünya: Kendimizi bulma yolunda atacağımız önemli adımlara işaret eder. Kişinin kendisiyle ve evrenle bütünleşmesi. Hedefe ulaşma, uyum, mutluluk, başarı.""")
    

gun = input("gün giriniz: ")
gkontrol(gun)
ay = input("ay giriniz: ")
aykontrol(ay)
yil = input("yıl giriniz: ")
yilkontrol(yil)

toplam =islemler(gun,ay,yil)
aciklama=aciklamayaz(toplam)