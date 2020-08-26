using StoreApp.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.DataAccess.Concrete.EntityFramework
{
    //DropCreateDatabaseIfModelChanges

    //program her calıstıgında veritabanını silip tekrar olusturma:DropCreateDatabaseAlways

    //DropCreateDatabaseIfModelChanges<StoreContext>
    public class StoreInitializer: DropCreateDatabaseAlways<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            List<Category> categories = new List<Category>()
            {
            new Category() { Name = "Televizyon",UpdateDate=DateTime.Now,UpdateBy=1,IsDeleted=false,InsertBy=1,InsertDate=DateTime.Now},
            new Category() { Name = "Telefon",UpdateDate=DateTime.Now,UpdateBy=1,IsDeleted=false,InsertBy=1,InsertDate=DateTime.Now },
            new Category() { Name = "Beyaz Eşya" ,UpdateDate=DateTime.Now,UpdateBy=1,IsDeleted=false,InsertBy=1,InsertDate=DateTime.Now},
            new Category() { Name = "Bilgisayar" ,UpdateDate=DateTime.Now,UpdateBy=1,IsDeleted=false,InsertBy=1,InsertDate=DateTime.Now},
            new Category() { Name = "Ayakkabı" ,UpdateDate=DateTime.Now,UpdateBy=1,IsDeleted=false,InsertBy=1,InsertDate=DateTime.Now},
            new Category() { Name = "Elektrikli Ev Aletleri" ,UpdateDate=DateTime.Now,UpdateBy=1,IsDeleted=false,InsertBy=1,InsertDate=DateTime.Now},
            new Category() { Name = "Giyim" ,UpdateDate=DateTime.Now,UpdateBy=1,IsDeleted=false,InsertBy=1,InsertDate=DateTime.Now},
           
            };

            foreach (var item in categories)
            {
                context.Categories.Add(item);
            }
            context.SaveChanges();

            List<Product> products = new List<Product>()
            {
                 new Product(){Name="SONY 1.3X",Description="Özellikleri:Wifi,USB 2.0,Full HD,60 İnç,",Image="Sony.jpg",isHome=true,isApproved=true,isFeatured=true,Price=6000,Stock=1080,CategoryId=1,UpdateDate=DateTime.Now,UpdateBy=1,IsDeleted=false,InsertBy=1,InsertDate=DateTime.Now},
                 new Product(){Name="LG 56.0 D",Description="Özellikleri:Wifi,USB 3.0,4K,70 İnç",Image="LG.jpg",isHome=true,isApproved=true,isFeatured=true,Price=9100,Stock=1700,CategoryId=1,UpdateDate=DateTime.Now,UpdateBy=1,IsDeleted=false,InsertBy=1,InsertDate=DateTime.Now},
                 new Product(){Name="Apple 7 Plus",Description="Özellikleri:4 GB RAM,Arka Kamera:13 MP,Ön Kamera:5 MP,2500 mAh,32 GB,İOS 11",Image="Apple.jpg",isHome=true,isApproved=true,isFeatured=true,Price=6100,Stock=1020,CategoryId=2,UpdateDate=DateTime.Now,UpdateBy=1,IsDeleted=false,InsertBy=1,InsertDate=DateTime.Now},
                 new Product(){Name="Samsung Edge 7",Description="Özellikleri:4 GB RAM,Arka Kamera:18 MP,Ön Kamera:8 MP,3000 mAh,32 GB,Android 8.0 ",Image="Samsung.jpg",isHome=true,isApproved=true,isFeatured=true,Price=5100,Stock=1100,CategoryId=2,UpdateDate=DateTime.Now,UpdateBy=1,IsDeleted=false,InsertBy=1,InsertDate=DateTime.Now},
                 new Product(){Name="Profilo S3X",Description="Özellikleri:A++,Genişlik 59 cm,Ses Seviyesi 52 dB,Kapasite 12 kişilik",Image="Profilo.jpg",isHome=true,isApproved=true,isFeatured=true,Price=8500,Stock=1010,CategoryId=3,UpdateDate=DateTime.Now,UpdateBy=1,IsDeleted=false,InsertBy=1,InsertDate=DateTime.Now},
                 new Product(){Name="Beko B52",Description="Özellikleri:A+++,Genişlik 57 cm,Derinlik 59 cm,Kapasite 9 kg",Image="Beko.jpg",isHome=true,isApproved=true,isFeatured=true,Price=9200,Stock=1050,CategoryId=3,UpdateDate=DateTime.Now,UpdateBy=1,IsDeleted=false,InsertBy=1,InsertDate=DateTime.Now},
                 new Product(){Name="Xiaomi Red Mi Note 7",Description="Özellikleri:4 GB RAM, Arka Kamera: 32 MP,Ön Kamera:18 MP,4500 mAh,64 GB,Android 9.0",Image="Xiaomi.jpg",isHome=true,isApproved=true,isFeatured=true,Price=2100,Stock=400,CategoryId=2,UpdateDate=DateTime.Now,UpdateBy=1,IsDeleted=false,InsertBy=1,InsertDate=DateTime.Now},
                 new Product(){Name="Huawei P30 Pro",Description="Özellikleri:8 GB RAM, Arka Kamera: 34 MP,Ön Kamera:32 MP,5000 mAh,128 GB,Android 9.0",Image="Huawei.jpg",isHome=true,isApproved=true,isFeatured=true,Price=4000,Stock=470,CategoryId=2,UpdateDate=DateTime.Now,UpdateBy=1,IsDeleted=false,InsertBy=1,InsertDate=DateTime.Now},
                 new Product(){Name="Bosch NMX",Description="Özellikleri:A++,Genişlik 59 cm,Ses Seviyesi 42 dB,Kapasite 300 Lt",Image="Bosh.jpg",isHome=true,isApproved=true,isFeatured=true,Price=1000,Stock=452,CategoryId=3,UpdateDate=DateTime.Now,UpdateBy=1,IsDeleted=false,InsertBy=1,InsertDate=DateTime.Now},
                 new Product(){Name="Lenovo GX5",Description="Özellikleri:8 GB RAM,İşlemci i7,İşlemci Hızı 2,40 GHz,Widows 10,Ekran Kartı Nvidia GTX1050 Ti,Dahili Hafıza 1 TB,128 GB SSD",Image="Lenovo.jpg",isHome=true,isApproved=true,isFeatured=true,Price=3500,Stock=200,CategoryId=4,UpdateDate=DateTime.Now,UpdateBy=1,IsDeleted=false,InsertBy=1,InsertDate=DateTime.Now},
                 new Product(){Name="Dell D5X",Description="Özellikleri:4 GB RAM,İşlemci i5,İşlemci Hızı 2,10 GHz,Widows 10,Ekran Kartı Nvidia GTX1050,Dahili Hafıza 1 TB,8 GB SSD",Image="Dell.jpg",isHome=true,isApproved=true,isFeatured=true,Price=4100,Stock=300,CategoryId=4,UpdateDate=DateTime.Now,UpdateBy=1,IsDeleted=false,InsertBy=1,InsertDate=DateTime.Now},
                 new Product(){Name="Casper T3V",Description="Özellikleri:4 GB RAM,İşlemci i5,İşlemci Hızı 2,20 GHz,Widows 10,Ekran Kartı Nvidia GTX1050,Dahili Hafıza 1 TB,4 GB SSD",Image="Casper.jpg",isHome=true,isApproved=true,isFeatured=true,Price=5100,Stock=500,CategoryId=4,UpdateDate=DateTime.Now,UpdateBy=1,IsDeleted=false,InsertBy=1,InsertDate=DateTime.Now},
                 new Product(){Name="Nike M2K",Description="Özellikleri:Erkek Koşu Ayakkabısı,Renk Siyah",Image="Nike.jpg",isHome=true,isApproved=true,isFeatured=true,Price=500,Stock=240,CategoryId=5,UpdateDate=DateTime.Now,UpdateBy=1,IsDeleted=false,InsertBy=1,InsertDate=DateTime.Now},
                 new Product(){Name="Adidas QA5",Description="Özellikleri:Kadın Koşu Ayakkabısı,Renk Beyaz",Image="Adidas.jpg",isHome=true,isApproved=true,isFeatured=true,Price=300,Stock=258,CategoryId=5,UpdateDate=DateTime.Now,UpdateBy=1,IsDeleted=false,InsertBy=1,InsertDate=DateTime.Now},
                 new Product(){Name="Puma 2K4",Description="Özellikleri:Erkek Sneaker,Renk Siyah",Image="Puma.jpg",isHome=true,isApproved=true,isFeatured=true,Price=400,Stock=860,CategoryId=5,UpdateDate=DateTime.Now,UpdateBy=1,IsDeleted=false,InsertBy=1,InsertDate=DateTime.Now},
                 new Product(){Name="Korkmaz TX",Description="Özellikleri:Demlik Malzemesi Çelik, 1600 Watt,Demlik Kapasitesi 2 Litre",Image="Korkmaz.jpg",isHome=true,isApproved=true,isFeatured=true,Price=600,Stock=785,CategoryId=6,UpdateDate=DateTime.Now,UpdateBy=1,IsDeleted=false,InsertBy=1,InsertDate=DateTime.Now},
                 new Product(){Name="Tefal 1X",Description="Özellikleri:Kablo Uzunluğu 2 Metre,2600 Watt,Su Doldurma Kapasitesi 300 ml",Image="Tefal.jpg",isHome=true,isApproved=true,isFeatured=true,Price=520,Stock=150,CategoryId=6,UpdateDate=DateTime.Now,UpdateBy=1,IsDeleted=false,InsertBy=1,InsertDate=DateTime.Now},
                 new Product(){Name="Schafer 5MG",Description="Özellikleri:Otomatik Kapanma,Su Hacmi 2 Litre",Image="Schafer.jpg",isHome=true,isApproved=true,isFeatured=true,Price=800,Stock=895,CategoryId=6,UpdateDate=DateTime.Now,UpdateBy=1,IsDeleted=false,InsertBy=1,InsertDate=DateTime.Now},
                 new Product(){Name="Karaca VB1",Description="Özellikleri:Torbasız,Ses Seviyesi 80 dB,Toz Hacmi 1.5 Litre",Image="Karaca.jpg",isHome=true,isApproved=true,isFeatured=true,Price=1800,Stock=550,CategoryId=6,UpdateDate=DateTime.Now,UpdateBy=1,IsDeleted=false,InsertBy=1,InsertDate=DateTime.Now},
                 new Product(){Name="Koton JK1",Description="Özellikleri:Su Geçirmez,%100 Pamuk",Image="Koton.jpg",isHome=true,isApproved=true,isFeatured=true,Price=380,Stock=780,CategoryId=7,UpdateDate=DateTime.Now,UpdateBy=1,IsDeleted=false,InsertBy=1,InsertDate=DateTime.Now},
                 new Product(){Name="Mavi DF1",Description="Su Geçirmez,%60 Pamuk",Image="Mavi.jpg",isHome=true,isApproved=true,isFeatured=true,Price=200,Stock=450,CategoryId=7,UpdateDate=DateTime.Now,UpdateBy=1,IsDeleted=false,InsertBy=1,InsertDate=DateTime.Now},
                 new Product(){Name="Waikiki WK1",Description="Su Geçirmez,%80 Pamuk",Image="Waikiki.jpg",isHome=true,isApproved=true,isFeatured=true,Price=300,Stock=540,CategoryId=7,UpdateDate=DateTime.Now,UpdateBy=1,IsDeleted=false,InsertBy=1,InsertDate=DateTime.Now}

            };

            foreach (var item in products)
            {
                context.Ptoducts.Add(item);
            }

            context.SaveChanges();

            List<Order> orders = new List<Order>()
            {
                 new Order(){ProductID=1,OrderDate = DateTime.Now,UserID=null,Price=6000,Amount=1,Piece=1,UpdateDate=DateTime.Now,UpdateBy=1,InsertDate=DateTime.Now,InsertBy=1,IsDeleted=true },
                 new Order(){ProductID=2,OrderDate = DateTime.Now,UserID=null,Price=9100,Amount=1,Piece=1,UpdateDate=DateTime.Now,UpdateBy=1,InsertDate=DateTime.Now,InsertBy=1,IsDeleted=true },
                 

            };
            foreach (var items in orders)
            {
                context.Orders.Add(items);
            }

            context.SaveChanges();
            List<AccountPerson> AccountPersons = new List<AccountPerson>()
            {
                new AccountPerson(){FirstName="Burak",LastName="Erdem",PicturePath="52.jpg",Phone="05564236598",UpdateDate=DateTime.Now,UpdateBy=1,IsDeleted=true,InsertDate=DateTime.Now,InsertedBy=1},
                new AccountPerson(){FirstName="Güngör",LastName="Temel",PicturePath="52.jpg",Phone="05564236598",UpdateDate=DateTime.Now,UpdateBy=1,IsDeleted=true,InsertDate=DateTime.Now,InsertedBy=1},
            };

            foreach (var item in AccountPersons)
            {
                context.AccountPersons.Add(item);
            }
            context.SaveChanges();

            List<AccountRole> AccountRoles = new List<AccountRole>()
            {
                new AccountRole(){RoleName="Admin",Description="Sistem Yetkilisi",UpdateDate=DateTime.Now,UpdateBy=1,IsDeleted=false,InsertDate=DateTime.Now,InsertedBy=1},
                new AccountRole(){RoleName="Customer",Description="Müşteri",UpdateDate=DateTime.Now,UpdateBy=1,IsDeleted=false,InsertDate=DateTime.Now,InsertedBy=1},
                new AccountRole(){RoleName="SalesManager",Description="Satış Müdürü",UpdateDate=DateTime.Now,UpdateBy=1,IsDeleted=false,InsertDate=DateTime.Now,InsertedBy=1},
                new AccountRole(){RoleName="SalesSpecialist",Description="Satış Yetkilisi",UpdateDate=DateTime.Now,UpdateBy=1,IsDeleted=false,InsertDate=DateTime.Now,InsertedBy=1},
            };

            foreach (var item in AccountRoles)
            {
                context.AccountRoles.Add(item);
            }
            context.SaveChanges();

            List<AccountUser> AccountUsers = new List<AccountUser>()
            {
                new AccountUser(){PersonID=1,AccountRoleID=1,UserName="Admin",UserMailAddress="admin@gmail.com",Password="1q2w3e4r",LastLoginDate=DateTime.Now,LockedOut=true,UpdateDate=DateTime.Now,UpdateBy=1,IsDeleted=false,InsertDate=DateTime.Now,InsertBy=1},
                new AccountUser(){PersonID=2,AccountRoleID=2,UserName="Customer1",UserMailAddress="customer1@gmail.com",Password="1q2w3e4r",LastLoginDate=DateTime.Now,LockedOut=true,UpdateDate=DateTime.Now,UpdateBy=1,IsDeleted=false,InsertDate=DateTime.Now,InsertBy=1},

            };
            foreach (var item in AccountUsers)
            {
                context.AccountUsers.Add(item);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
