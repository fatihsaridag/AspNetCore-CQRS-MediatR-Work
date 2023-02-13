# AspNetCore-CQRS-MediatR-Work
AspNetCore CQRS Pattern ve MediatR kütüphanesi kullanımına örnek küçük bir çalışma reposu. Bu küçük repo da CQRS ile QueryModel ve CommendModel kullanarak listeleme(reads) ve oluşturma(writes) işlemi gerçekleştirdim.

## Commands ##
Veri üzerinde bir değişiklik yapılacaksa Commands kullanılır. Commands sınıfı içindeki handler white storage'ı besliyor.

## Query ##
Veri üzerinde bir değişiklik yapılmadan presentation katmanına sunulacaksa query ler kullanılır. Databaseden data okunup presentation katmanına sunulur.

## İlgili Resimler ##

![5](https://user-images.githubusercontent.com/68101192/218467509-0b4e14cb-f2d3-4b90-8a0e-8eaf1b3ee598.PNG)
![1](https://user-images.githubusercontent.com/68101192/218467237-6bcadc8a-ae26-48ff-b197-ad3884569c27.png)
![2](https://user-images.githubusercontent.com/68101192/218467251-72b1f060-131c-48d9-87c1-ef148a2c26f0.png)
![3](https://user-images.githubusercontent.com/68101192/218467258-f465f4a5-8b71-4655-ad97-2c9cc7acece0.png)
