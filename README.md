# Facade-Pattern---Basic-Ads-Example
Farklı Ads Plugin'lerinin Facade Pattern ile birleştirilmesini içeren basit bir FPS prototipini içeren repo'dur.<br><br>

<b>GameManager.cs</b> => 5 saniyede bir temsili banner ad çağıran bir sınıftır.<br>
<b>IAdPlugin</b> => Farklı AdPlugin'leri soyutladığımız interface'tir. AdPlugin1.cs, AdPlugin2.cs gibi farklı AdPlugin'ler bu interface üzerinden soyutlama için gerekli metodları uygularlar.<br>
<b>FacadeAdsManager.cs</b> => Bu Facade sınıf, her bir Adplugin'in initialization'ınından sorumludur. GetBestCPM metodu ile AdPlugin'leri içerisinden en yüksek CPM'i vereni tespit eder ve onun ShowAds metodunu çalıştırır. Bu sayede herhangi bir plugin eklemek istediğimizde, IAdPlugin interface'ini implemente etmemiz ve FacadeAdsManager'da initialize etmemiz yeterlidir.


