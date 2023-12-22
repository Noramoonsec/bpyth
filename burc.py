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
    sonuc=int(gun[0]) + int(gun[1]) + int(ay[0]) + int(ay[1]) + int(yil[0]) + int(yil[1]) + int(yil[2]) + int(yil[3])
    if sonuc>9 and sonuc!=11 or sonuc>9 and sonuc!=22:
        strsonuc=str(sonuc)
        ysonuc=int(strsonuc[0])+int(strsonuc[1])
    sonuc=ysonuc
    return sonuc
def aciklamayaz(aciklama):
    if toplam ==1:
       aciklama == print("""
1: Numeroloji sisteminde 1 sayısının anlamı; Bağımsızlık, yaratıcılık, kendine düşkünlük, ego olarak ifade edilir. 
Kişi hem kendine yeterli hem de tam bir liderdir. Yani liderliği temsil eder. 
İş yaşamında acelecilik, aşırılık ve hükmedici davranışlardan kaçınması kişi adına fayda sağlayabilir.
""")
    if toplam ==2:
        aciklama == print("""2: Kişilik özellikler; bağımlılık, aşırı duyarlılık, kavrama ve tasarım, 
                          iş birlik anlayışı ve sezgi yeteneği gelişmiştir. 
                          Kişi sevgi dolu, eleştirici ve barış yanlısı, ideal ortaktır. 
                          Detaylara takılmaktan ve yalnızlıktan kaçınmalıdır.""")

    
    if toplam ==3:
        aciklama == print("""3: Numerolojide 3 rakamı; sosyal, arkadaş canlısı, sanata yatkın, iyimser, 
                          ziyankarlık, yüzeysellik anlamlarına gelir. Dışa dönük bir kişidir. Yaşamı ve eğlenceyi sever. 
                          Oldukça yaratıcı ve duyarlıdır. Rutini sevmez. Kendine disiplin uygulamayı benimsemesi gerekir.""")
    if toplam ==4:
        aciklama == print("""4: Numerolojide 4 sayısı sağlam, pratik, uygulayıcı, bükülmez ve sıkı bir çalışan anlamına gelir.
                           Her konuda başarıyı yakalamak ister. Candan ve iyi bir arkadaş olma konusunda yardıma ihtiyacı vardır. 
                          Aşırı güvenlik duygusuna kapılmamalıdır.""")
    if toplam ==5:
        aciklama== print("""5: Özgürlük, gezginlik, uyum kabiliyeti, değişkenlik gibi karakteristik özellikler numerolojide bu rakamın karşılığı olarak bilinmektedir.
                          İkna edici bir kişiliğe sahiptir ve cesur bir kişiliktir. Can sıkıntısı olumsuz etkiler. 
                         Amacından kolayca sapması söz konusudur.""")
    if toplam ==6:
        aciklama== print("""6: Anlayış, aşk, sorumluluk, kıskançlık, her işe müdahale etmek gibi özelliklere sahiptir.
                          Oldukça sıcak, koruyucu ve mutlu bir kişiliğe sahiptir.
                          Sevdikleri için fedakarlık yapmaktan çekinmez. 
                         Sağlam ve güvenilir bir yapısı bulunur. Kendini kötümser bir ruh haline sokmaktan ve başkaları tarafından istismar edilen duygularından arınmış olmalıdır.
""")
    if toplam ==7:
        aciklama== print("""7: Bu rakam; sır saklama, zeka, ruhsallık ve baskıcılığı ifade eder.
                         Düşünür bir kişiliğe sahiptir. 
                         Değişken ve eksantriktir. 
                         Mesafeli ve soğuk olmaktan kaçınmalıdır.
                          Ayrıca iyi şeylere sahip olmama duygusu ve yalnızlıktan kaçınmalıdır.
""")
    if toplam ==8:
        aciklama== print("""8: Organizasyon yeteneğine sahip, güçlü, yönetici ruha sahip ve oldukça adildir. 
                         Sonuca giden bir kişiliğe sahiptir. 
                         Bu bağlamda her zaman kararlı ve güçlü yapısı ile ön plana çıkmaktadır. 
                         Özellikle maddi konularda başarılıdır. Hedefinin karşısında gördüğü kişilere karşı duygusuzca davranmaktan kaçınması gerekir.""")
    if toplam ==9:
        aciklama== print("""9: Hümanist, romantik, şefkatli, duygusal, sanatkar, sezgili, duyarlı, yaratıcı ve konforuna düşkündür. 
                         Kendini anlatmak adına tüm dünya ile savaşabilir. 
                         Kötü alışkanlıklarından arınmak ve yaşamın küçük detaylarından olumsuz etkilenmemek adına gayret göstermesi gerekir""")
    if toplam ==11:
        aciklama== print("""11: Duyarlı, fanatik ve sezgi gücü yüksektir. Ayrıca keşif yeteneğine sahiptir. 
                         Öngörülü ve hayalci bir kişiliğe sahiptir.
                          Bilinç üstü gelişmiştir ve sanatkardır.
                          Aşırı duyarlılık ve gerginlik halinden uzak durmalıdır.""")
    if toplam ==22:

        aciklama== print("""22: Numerolojide 22 rakamının anlamı; maddi alanda üstün, zenginliğe kolay ulaşabilen,
                          oldukça pratik bir idealist olarak tanımlanır. 
                         Amacına doğru ilerler ve eli çabuktur. Düşünce tarzı globaldir. 
                         Geleceğe fazla düşünmekten kaçınmalıdır.""")


gun = input("gününüzü giriniz: ")
gkontrol(gun)
ay = input("ay giriniz ")
aykontrol(ay)
yil = input(" yil giriniz : ")
yilkontrol(yil)
toplam=islemler(gun,ay,yil)
aciklama=aciklamayaz(toplam)