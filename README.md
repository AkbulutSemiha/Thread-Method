# Thread-Method
Bu projede amaç eş zamanlı olarak çalışan 2 iş parçacığının kullanılması.

1' den 100' e kadar ardaşık olarak sayı üretilmesi ve bu sayının ekrana basılması için 2 faklı thread oluşturulmuştur. Bu 2 thread tarafından ortak kaynağa erişim sağlandığından dolayı bu erişimi düzenleyebilmek ve sırayla olmasını sağlamak amacıyla Mutex kullanılmıştır. Kaynağa erişimin sağlandığı kritik kod bloğunun bulunduğu alanda Mutex'i alma ve işlem tamamlandıktan sonra serbest bırakma ile işlemde senkronizasyon sağlanmıştır.

Print() --> Bu metot ile ortak kaynağın ekrana yazılması ve random olarak oluşturulan süreç boyunca bu thread'in uyutulması işlemi yapılmıştır.

GenerateNumber() --> Bu metot ile ortak kaynağın arttırılması ve üretilen süre boyunca thread'in bekletilmesi işlemi yapılmıştır.

