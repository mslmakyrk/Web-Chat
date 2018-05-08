namespace WebChat.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WebChatDataBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kullanicis",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AdSoyad = c.String(nullable: false),
                        Sifre = c.String(),
                        Mail = c.String(),
                        Telefon = c.String(),
                        Rol = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Mesajlars",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Mesaj = c.String(),
                        Tarih = c.DateTime(nullable: false),
                        Okundu = c.Boolean(nullable: false),
                        Aktif = c.Boolean(nullable: false),
                        kullaniciALN_ID = c.Int(),
                        kullaniciGND_ID = c.Int(),
                        Kullanici_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Kullanicis", t => t.kullaniciALN_ID)
                .ForeignKey("dbo.Kullanicis", t => t.kullaniciGND_ID)
                .ForeignKey("dbo.Kullanicis", t => t.Kullanici_ID)
                .Index(t => t.kullaniciALN_ID)
                .Index(t => t.kullaniciGND_ID)
                .Index(t => t.Kullanici_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Mesajlars", "Kullanici_ID", "dbo.Kullanicis");
            DropForeignKey("dbo.Mesajlars", "kullaniciGND_ID", "dbo.Kullanicis");
            DropForeignKey("dbo.Mesajlars", "kullaniciALN_ID", "dbo.Kullanicis");
            DropIndex("dbo.Mesajlars", new[] { "Kullanici_ID" });
            DropIndex("dbo.Mesajlars", new[] { "kullaniciGND_ID" });
            DropIndex("dbo.Mesajlars", new[] { "kullaniciALN_ID" });
            DropTable("dbo.Mesajlars");
            DropTable("dbo.Kullanicis");
        }
    }
}
