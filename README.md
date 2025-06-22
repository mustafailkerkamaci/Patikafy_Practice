![image](https://github.com/user-attachments/assets/9df787e7-0176-409d-9bf0-0c81b1795ccd)
# Şarkıcı Bilgileri Analiz Projesi

Bu proje, belirlenen şarkıcılara ait çıkış yılı, müzik türü ve albüm satışları gibi bilgileri içeren bir C# konsol uygulamasıdır. Uygulama, bu verileri kullanarak çeşitli sorgulamalar yapar ve sonuçları konsola yazdırır.

## Özellikler

Bu uygulama aşağıdaki temel özellikleri sunar:

-   **Şarkıcı Verisi Depolama**: Her bir şarkıcının adı, müzik türü, çıkış yılı ve albüm satışlarını (sayısal olarak) içeren `Singer` nesnelerini bir liste (`List<Singer>`) içinde tutar.
-   **Veri Formatlama**: Albüm satışları gibi sayısal verileri daha okunaklı "Yaklaşık X milyon" formatına dönüştürebilen yardımcı bir metot içerir.
-   **Temel Sorgulamalar**: Aşağıdaki gibi LINQ (Language Integrated Query) kullanarak veri üzerinde çeşitli filtreleme, gruplama ve sıralama işlemleri yapar:
    -   Adı 'S' ile başlayan şarkıcıları listeler.
    -   Albüm satışları 10 milyonun üzerinde olan şarkıcıları listeler.
    -   2000 yılı öncesi çıkış yapmış ve Pop müzik yapan şarkıcıları, çıkış yıllarına göre gruplayarak ve her grubu kendi içinde alfabetik olarak sıralayarak listeler.
    -   En çok albüm satan şarkıcıyı bulur.
    -   En yeni ve en eski çıkış yapan şarkıcıları bulur.
