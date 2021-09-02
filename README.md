# simulatorpck
c# rs422 simulator

## buralarda noldu
![yarı çalışan ve hiç çalışmayan sürümler için](https://github.com/tonyukukkula/simulatorpck/tree/main/eskiler)

## pcksimululatorv2 ne için?
En basit şekilde temel bir RS422 seri haberleşme ekranıdır. Daha rs422 packet simulator olamamıştır. Şimdi bu yolda ilerlenmektedir.
![resim](https://user-images.githubusercontent.com/44534126/131826781-b19ef879-eab6-452e-bec7-881a608ef3da.png)
gözüktüğü üzere UX tavan tavann.

---
## v2.1 ne için?
Paket simülatörü olma yolunda emin adımlarla ilerleyen *simulatorpck* bu uğurda belirli bir yapıya sahip değişken büyüklükte paket oluşturabilme becerisi kazandı, elimin altında deneyecek modem olmadığından dolayı 2 bilgisayar ile denenebilir şekilde kodlanmıştır. 
+ TX ve RX alanlarını temizleme butonları ve "Port Tarama" butonu eklenmiştir.

![resim](https://user-images.githubusercontent.com/44534126/131889445-1303c6b8-071a-4ec3-9318-eeb5200de4ce.png)
Resimde gözüktüğü üzere ilgili alandan istediğimiz paket büyüklüğünü byte olarak girdikten sonra şu şekilde bir paket oluşturuyor:
- ilk byte = header(51)
- (2.) ve 3. byte'lar birlikte bir short(16 bit integer) tutuyor = paket büyüklüğü(size)
- (size-3). ve (size-2). byte'lar birlikte bir unsigned short tutuyor = checksum
  - Burada bir tatavamız var: 2 byte checksum en fazla 65535 tutabilir, eğer paketteki 3 birim içteki tüm byte'lar 0xFF olursa burada denklemimiz: 255 X size-6 < 65535 yani size < (65535 + (255 X 6))/255 ==> size < 263 demektir. Bu yüzden Exception'a düşmeyelim diye tatavamız: paket sayımız 7'den büyük, 263'den küçük olmalıdır.
- (size-1). byte, yani son byte = footer(75)
- bahsi geçmeyen sıradaki byte'lar uşşak(random) bir şekilde oluşmaktadır. 
