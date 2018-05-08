
function Duzenle() {
    Kullanici = new Object();
    Kullanici.ID = $("#ID").val();
    Kullanici.AdSoyad = $("#AdSoyad").val();
    Kullanici.Mail = $("#Mail").val();
    Kullanici.Telefon = $("#Telefon").val();
    Kullanici.Rol = $("#Rol").val();
    Kullanici.Sifre = $("#Sifre").val();
    if (Kullanici.AdSoyad == '' || Kullanici.Mail == '' || Kullanici.Rol == null || Kullanici.Sifre == '')
    {
        alert("Lütfen Gerekli Alanları Doldurunuz...");
    }
    else
    {
        $.ajax({
            url: "/Home/Duzenle",
            data: Kullanici,
            type: "Post",
            dataType: 'json',
            success: function (response) {
                alert("mesaj : " + response);
                location.assign("../../Home/Listele");
            }
        });
    }
       
}
function KullaniciEkle() {

    Kullanici = new Object();
    Kullanici.AdSoyad = $("#AdSoyad").val();
    Kullanici.Mail = $("#Mail").val();
    Kullanici.Telefon = $("#Telefon").val();
    Kullanici.Rol = $("#Rol").val();
    Kullanici.Sifre = $("#Sifre").val();
    if (Kullanici.AdSoyad == '' || Kullanici.Mail == '' || Kullanici.Rol == null || Kullanici.Sifre=='') {
        alert("Lütfen Gerekli Alanları Doldurunuz...");
    }
    else {
        alert("ad : " + Kullanici.AdSoyad + " mail : " + Kullanici.Mail + " tel : " + Kullanici.Telefon + " Rol : " + Kullanici.Rol + " sifre : " + Kullanici.Sifre);
        $.ajax({
            url: "/Home/Ekle",
            data: Kullanici,
            type: "Post",
            dataType: 'json',
            success: function (response) {
                alert(response);
                location.reload();
            },
            error: function (response) {
                alert("Hatalı kayıt : " + response);
            }
        });
    }
}
function KategoriSil(id) {
    $.ajax({
        url: "/Home/Sil/" + id,
        type: "Post",
        dataType: 'json',
        success: function (response) { 
            alert("Kayıt Silindi");
            location.assign("../../Home/Listele");
        }
    });
}



