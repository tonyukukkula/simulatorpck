# simulatorpck
c# rs422 simulator

## buralarda noldu
20 gün önce ilk sürümü çıkmıştı, sonrasında tx çalışmıyor diye v1.1 için çalışayım derken araya yökdil girdi şimdi oturup baktığımda aslında hatanın tek satırda bir tatavadan ibaret olduğunu gördüm:
![resim](https://user-images.githubusercontent.com/44534126/131502180-46e04f5e-704c-4aab-9e52-8f8ea1108102.png)

Tabi bu tatavayı geçene kadar sabah 2 saatim arayüzü güncellemekle geçti ve bu hatayı fark ettikten sonra v1.1 yayımlansın deyiverdim.

## ne v1.1miş ula!?
şincik v1 tamamen kullanım kolaylığı ve mükemmel ux'a sahip olması amacındaydım, istenenlerden biraz uzak ama işe yaramasını tahmin ettiğim bir yapısı vardı.\
![resim](https://user-images.githubusercontent.com/44534126/131502611-7785e5f1-777d-4856-8757-9bd9f5e00ae3.png)

---
![resim](https://user-images.githubusercontent.com/44534126/131504283-1495c3bb-867d-4074-b4b3-11d124787804.png)
burada ilginç bir şekilde RX çalışırken TX çalışmıyordu. Nedeni ise "buralarda noldu" kısmındaki ekran görüntüsünde saklı...
tabi sadece bu değildi, pencere(RX veya TX) kapandıktan sonra tekrar açılması için programın yeniden başlaması gerekiyordu çünkü disposed edilmiş bir nesne için garbage collection yolları taştandır. Bir de kullanıcıya şunu yapıyom bunu yapıyom imajı vermiyordu program.....

### YÜCE v1.1!!!!
burada v1.1'in yüceliği önem kazanmaktadır, çünkü yukarıda sayılmış tatavaların hepsi halledilmiş ayrıca daha kullanıcı dostu bir arayüz sağlanmıştır. Lâkin daha taze olduğu için kafamdaki her şeyi yapmadım, ayrıca daha test etme fırsatı bulunmadığı için TX derdini hallettik mi emin değiliz, lakin hal olmazsa ben bu kafayı buradan keserim.
![resim](https://user-images.githubusercontent.com/44534126/131505280-b15aff05-5d2b-475e-a83d-99f7ea1740d3.png)
#### açılış ekranı yukarıdaki gibidir.\
![resim](https://user-images.githubusercontent.com/44534126/131505377-a0dcee22-0d33-40b7-b8cb-cbe6aa76666d.png)
#### öncelikle tüm ayarlar ilgili yerlerden seçilmelidir. "Port ayarları" kısmındaki yerlerde seçili gözüken ayarlar 'default' olarak olması gereken ayarları göstermektedir. Bağlan demeden önce oradaki ayarlardan da seçim yapmayı unutmayınız.\
![resim](https://user-images.githubusercontent.com/44534126/131505656-c4f2cee8-2b8a-4005-b299-bfaa5d714d68.png)
- pencere isimleri güncellendi
- buttona renk geldi
- form element isimleri değiştirldi(kod okunabilirliği arttı)
- gereksiz şeyler silindi
- pencere kapattıktan sonra programı kapat-aç yapmaya gerek kalmadı.
![resim](https://user-images.githubusercontent.com/44534126/131505843-18f1d7d3-96ca-4b23-b110-bb408125474d.png)
- Compare modu seçilmedikçe paket sayısı alanı gizli kalması eklendi.
