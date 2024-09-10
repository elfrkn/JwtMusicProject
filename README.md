# JwtMusicProject
Bu proje Json Web Token kullanılarak sisteme giriş yapılır.Basic,Flex,Gold ve Premium olmak üzüre 4 tane üyelik sistemi vardır.Kullanıcı sisteme giriş yaptığında sadece kendi üyelik tipine ait müzik listesini dinleyebilir.Sistemdeki tüm müzik listesine sadece kayıtlı üyeler erişebilir ve üyelik tipine göre bu listeden müzik dinleyebilir.Kullanıcı bir müziği dinlemek istediğinde seçtiği müziği dinleme yetkisi var mı diye sistem kontrolü yapılır.Kullanıcı token geçerlilik süresi bitene kadar müzik dinleyebilir.Tokenın süresi dolduğunda tekrar sisteme giriş yapması gerekmektedir.

## Kullanılan Teknolojiler
<ul>
 <li> Asp.Net Core 8 </li>
 <li> Jason Web Token </li>
 <li> Mssql </li>
 <li> SweetAlert </li>
 <li> Onion Architecture </li>
 <li> Web Api</li>
</ul>

 ### Müzik Listesi
 ![AllMusic](https://github.com/user-attachments/assets/ed98c69b-2162-4d8c-8d72-f2018f43fa2c)

 ### Giriş Yapan Kullanıcıya Ait Müzik Listesi
 ![GetMusicLitByRoleId](https://github.com/user-attachments/assets/3003085d-6a6d-4b6d-81df-2ef4bd551317)
 
 ### Jwt İle Yetki Sorgulama
 ![JwtRole](https://github.com/user-attachments/assets/5627d98c-9415-4bd0-921a-45134b1e5b90)

 ### Register Sayfası
 ![Register](https://github.com/user-attachments/assets/78a6367f-7ec0-4218-a2cb-56010b5684f4)

 ### Login Sayfası
 ![Login](https://github.com/user-attachments/assets/7260f7db-d04f-47bf-ac37-645deaf2309d)

 ### Swagger Jwt 
 ![Jwt](https://github.com/user-attachments/assets/4b11395d-6049-4166-8107-666673983c6e)


 
