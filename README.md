# Web-Chat
Proje katmanlı yapıda tasarlanıp .NET MVC kullanıldı. MSSQL veri tabanı üzerinde veriler tutuldu ve veri tabanı işlemleri ORM yapısını 
kullanan Entity Framework ile gerçekleştirildi ve veri tabanı Code First yöntemi ile oluşturuldu. WebChat.Data altında bu yapıyı 
görebilirsiniz. Gerçek zamanlı bir 
proje oluşturulduğundan SignalR kütüphanesi projeye eklenmiştir.Projede iki rol oluşturuldu bu rollerin yapabildikleri 
aşağıdaki gibidir.

## 1. Admin 
- Kullanıcı Ekleme
- Kullanıcı Silme
- Kullanıcı Güncelleme
- Bütün Mesajları Görebilme
- Toplu ve Özel Mesaj Gönderebilme

## 2. Kullanıcı
- Toplu ve Özel Mesaj Gönderebilme

## Mesajlaşma 
E-Mail ve şifre ile giriş yapıldıktan sonra gelen pencereden mesajlaşma uygulamasına gidilir. Açılan pencereden sağ tarafta aktif olan kişileri görebiliriz.
Özel mesaj göndermek istediğimiz kişinin üstüne tıklanarak açılan pencereden sohbet edilmeye başlanabilir.
Toplu mesajlaşma için ise alt taraftaki textbox kullanılarak mesaj gönderilebilir.
