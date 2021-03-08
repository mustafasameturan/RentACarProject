# RentACarProject

## 🌟Teşekkür 
Öncelikle bana bu projeyi yazmamda büyük desteği olan, bana çok değerli bilgiler katan Engin Demiroğ Hocama teşekkür ediyorum. Ayrıca bu yolda bana destek olan arkadaşlarıma ve aileme de teşekkürlerimi iletiyorum.

## 🌟Amaç
Projeyi yazmamdaki amacımdan bahsetmek istiyorum çünkü bunu projeyi daha anlamlı kılacak bir unsur olarak görüyorum. Başlıca amacım C# dilini, .NET dünyasını tanımak, bu yolda uzmanlaşmaktır. Yazdığım bu proje kendimi geliştirmeme vesile oluyor. Ayrıca bu proje ile birlikte SOLID yazılım tekniklerini öğreniyorum. Yazılım Geliştirici olma yolunda ilerlerken temelimi sağlam atmaya çalışıyorum ve sadece kendi penceremden değil, bu projeyi okuyacak, üstünde çalışacak insanların penceresinden de bakarak çalışmalarıma devam ediyorum.

## 🌟İçindekiler
- [Tanıtım](#tanıtım)
- [Kullanılan Teknolojiler](#kullanılan-teknolojiler)
- [Katmanlar](#katmanlar)
- [Sql Tables](#sql-tables)
- [Son Güncellemeler](#son-güncellemeler)

## ☑️Tanıtım
Projem adından da anlaşılacağı üzere bir araba kiralama sistemidir. Projemde, kendi oluşturduğum database üzerinden gelen bilgileri yönlendirerek;<br>

• Araba Ekle/Sil/Güncelle/Listele<br>
• Araba Gücü(HP) Ekle/Sil/Güncelle/Listele<br>
• Marka Ekle/Sil/Güncelle/Listele<br>
• Renk Ekle/Sil/Güncelle/Listele<br>
• Kullanıcı Ekle/Sil/Güncelle/Listele<br>
• Müşteri Ekle/Sil/Güncelle/Listele<br>
• Araba Kiralama Özelliği<br>

gibi imkanlar mevcuttur. Ayrıca projem bir katmanlı mimaridir. Projemin katmanlı mimarisi sayesinde kodun anlaşılabilirliği yüksektir. Tüm yazılan kodlar bir düzen içerisinde çalışmaktadır. Projemde kullandığım teknolojilerden bahsedeceğim fakat öncesinde sizden talep edilen farklı bir teknoloji kullanmak istediğinizde, projem herhangi bir zorluk yaratmayacaktır. Tamamen "Plug and Play" prensipi göz önüne alınarak tasarlanmıştır.

![Katmanlı Mimari](https://user-images.githubusercontent.com/77546366/108605441-21567d80-73c5-11eb-9536-fa39515740d4.PNG) 

## ☑️Kullanılan Teknolojiler
• Database → SQL <br>
• Köprü → EntityFramework <br>
• IoC Container → Autofac <br>
• Arabirim → WebAPI <br>
• Katmanlar → Business,DataAccess,Entity,Core,WebAPI <br> 

![Katmanlar](https://user-images.githubusercontent.com/77546366/108605460-3df2b580-73c5-11eb-9180-1cd05041a560.PNG)

## ☑️Son Güncellemeler
• Autofac desteği eklendi.<br>
• FluentValidation uygulaması sisteme entegre edildi.<br>
• AOP Desteği eklendi. <br>
• BusinessRules motoru eklendi.<br>
• JWT entegrasyonu yapıldı.<br>
• Security sistemi eklendi. Login, Register olma ve Yetki uygulaması sisteme eklendi.<br>
• Caching Aspect'i eklendi.<br>
• Transaction Aspect'i eklendi.<br>
• Performance Aspect'i eklendi.<br>


## ☑️Katmanlar

🗃 **``Business``** <br>
&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Abstract`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ICarService.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Business/Abstract/ICarService.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IBrandService.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Business/Abstract/IBrandService.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IColorService.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Business/Abstract/IColorService.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ICustomerService.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Business/Abstract/ICustomerService.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IRentalService.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Business/Abstract/IRentalService.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IUserService.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Business/Abstract/IUserService.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IPowerService.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Business/Abstract/IPowerService.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IAuthService.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Business/Abstract/IAuthService.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Concrete`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [CarManager.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Business/Concrete/CarManager.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [BrandManager.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Business/Concrete/BrandManager.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ColorManager.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Business/Concrete/ColorManager.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [CustomerManager.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Business/Concrete/CustomerManager.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [RentalManager.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Business/Concrete/RentalManager.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [UserManager.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Business/Concrete/UserManager.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [PowerManager.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Business/Concrete/PowerManager.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [AuthManager.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Business/Concrete/AuthManager.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``BusinessAspects`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Autofac`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [SecuredOperation.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Business/BusinessAspects/Autofac/SecuredOperation.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Constants`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [Messages.cs](https://github.com/mustafasameturan/RentACarProject/tree/master/Business/Constants) <br>

&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``DependencyResolvers`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Autofac`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [AutofacBusinessModule.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Business/DependencyResolvers/Autofac/AutofacBusinessModule.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``ValidationRules`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``FluentValidation`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [BrandValidator.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Business/ValidationRules/FluentValidation/BrandValidator.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [CarValidator.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Business/ValidationRules/FluentValidation/CarValidator.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ColorValidator.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Business/ValidationRules/FluentValidation/ColorValidator.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [CustomerValidator.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Business/ValidationRules/FluentValidation/CustomerValidator.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [RentalValidator.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Business/ValidationRules/FluentValidation/RentalValidator.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [UserValidator.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Business/ValidationRules/FluentValidation/UserValidator.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [PowerValidator.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Business/ValidationRules/FluentValidation/PowerValidator.cs) <br><br>


🗃 **``Core``** <br>
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Aspects`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Autofac`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Validation`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [ValidationAspect.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Core/Aspects/Autofac/Validation/ValidationAspect.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Caching`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [CacheAspect.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Core/Aspects/Autofac/Caching/CacheAspect.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [CacheRemoveAspect.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Core/Aspects/Autofac/Caching/CacheRemoveAspect.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Performance`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [PeformanceAspect.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Core/Aspects/Autofac/Performance/PerformanceAspect.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Transaction`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [TransactionScopeAspect.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Core/Aspects/Autofac/Transaction/TransactionScopeAspect.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp;📂 ``CrossCuttingConcerns`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Validation`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [ValidationTool.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Core/CrossCuttingConcerns/Validation/FluentValidation/ValidationTool.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Caching`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [ICacheManager.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Core/CrossCuttingConcerns/Caching/ICacheManager.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Microsoft`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [MemoryCacheManager.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Core/CrossCuttingConcerns/Caching/Microsoft/MemoryCacheManager.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp;📂 ``DependencyResolvers`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [CoreModule.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Core/DependencyResolvers/CoreModule.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp;📂 ``DataAccess`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IEntityRepository.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Core/DataAccess/IEntityRepository.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``EntityFramework`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [EfEntityRepositoryBase.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Core/DataAccess/EntityFramework/EfEntityRepositoryBase.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Entities`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Abstract`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IDto.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Core/Entities/IDto.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IEntity.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Core/Entities/IEntity.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Concrete`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  📃 [OperationClaim.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Core/Entities/Concrete/OperationClaim.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  📃 [User.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Core/Entities/Concrete/User.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  📃 [UserOperationClaim.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Core/Entities/Concrete/UserOperationClaim.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Extensions`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ClaimExtensions.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Core/Extensions/ClaimExtensions.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ClaimsPrincipalExtensions.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Core/Extensions/ClaimsPrincipalExtensions.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ServiceCollectionExtensions.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Core/Extensions/ServiceCollectionExtensions.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Utilities`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Interceptors`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [AspectInterceptorSelector.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Core/Utilities/Interceptors/AspectInterceptorSelector.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [MethodInterception.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Core/Utilities/Interceptors/MethodInterception.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [MethodInterceptionBaseAttribute.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Core/Utilities/Interceptors/MethodInterceptionBaseAttribute.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``BusinessRules`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [BusinessRules.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Core/Utilities/Business/BusinessRules.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``IoC`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ICoreModule.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Core/Utilities/IoC/ICoreModule.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ServiceTool.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Core/Utilities/IoC/ServiceTool.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Autofac`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Encryption`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [SecurityKeyHelper.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Core/Utilities/Security/Encryption/SecurityKeyHelper.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [SigningCredentialsHelper.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Core/Utilities/Security/Encryption/SigningCredentialsHelper.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Hashing`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [HashingHelper.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Core/Utilities/Security/Hashing/HashingHelper.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``JWT`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [AccessToken.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Core/Utilities/Security/JWT/AccessToken.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [ITokenHelper.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Core/Utilities/Security/JWT/ITokenHelper.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [JwtHelper](https://github.com/mustafasameturan/RentACarProject/blob/master/Core/Utilities/Security/JWT/JwtHelper.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [TokenOptions.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Core/Utilities/Security/JWT/TokenOptions.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Results`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IDataResult.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Core/Utilities/Results/IDataResult.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [DataResult.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Core/Utilities/Results/DataResult.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [SuccessDataResult.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Core/Utilities/Results/SuccessDataResult.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ErrorDataResult.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Core/Utilities/Results/ErrorDataResult.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IResult.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Core/Utilities/Results/IResult.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [Result.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Core/Utilities/Results/Result.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [SuccessResult.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Core/Utilities/Results/SuccessResult.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ErrorResult.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Core/Utilities/Results/ErrorResult.cs) <br><br>


🗃 **``Data Access``** <br>
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Abstract`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ICarDal.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/DataAccess/Abstract/ICarDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IBrandDal.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/DataAccess/Abstract/IBrandDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IColorDal.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/DataAccess/Abstract/IColorDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ICustomerDal.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/DataAccess/Abstract/ICustomerDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IRentalDal.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/DataAccess/Abstract/IRentalDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IUserDal.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/DataAccess/Abstract/IUserDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IPowerDal.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/DataAccess/Abstract/IPowerDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IUserDal.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/DataAccess/Abstract/IUserDal.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Concrete`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``EntityFramework`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  📃 [ReCapProjectDatabaseContext.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/DataAccess/Concrete/EntityFramework/ReCapProjectDatabaseContext.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  📃 [EfCarDal.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/DataAccess/Concrete/EntityFramework/EfCarDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  📃 [EfBrandDal.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/DataAccess/Concrete/EntityFramework/EfBrandDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  📃 [EfColorDal.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/DataAccess/Concrete/EntityFramework/EfColorDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  📃 [EfCustomerDal.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/DataAccess/Concrete/EntityFramework/EfCustomerDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  📃 [EfRentalDal.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/DataAccess/Concrete/EntityFramework/EfRentalDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  📃 [EfUserDal.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/DataAccess/Concrete/EntityFramework/EfUserDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  📃 [EfPowerDal.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/DataAccess/Concrete/EntityFramework/EfPowerDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  📃 [EfUserDal.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/DataAccess/Concrete/EntityFramework/EfUserDal.cs.cs) <br><br>


🗃 **``Entities``** <br>
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Concrete`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [Car.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Entities/Concrete/Car.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [Brand.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Entities/Concrete/Brand.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [Color.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Entities/Concrete/Color.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [Customer.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Entities/Concrete/Customer.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [Rental.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Entities/Concrete/Rental.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [User.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Entities/Concrete/User.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [Power.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Entities/Concrete/Power.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp;📂 ``DTOs`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [CarDetailDto.cs](https://github.com/mustafasameturan/RentACarProject/tree/master/Entities/DTOs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [RentalDetailDto.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Entities/DTOs/RentalDetailDto.cs) <br><br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [UserForLoginDto.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Entities/DTOs/UserForLoginDto.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [UserForRegisterDto.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/Entities/DTOs/UserForRegisterDto.cs) <br><br>


🗃 **``WebAPI``** <br>
&nbsp;&nbsp;&nbsp;&nbsp;📃 [Startup.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/WebAPI/Startup.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;📃 [Program.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/WebAPI/Program.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Controllers`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [BrandsController.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/WebAPI/Controllers/BrandsController.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [CarsController.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/WebAPI/Controllers/CarsController.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ColorsController.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/WebAPI/Controllers/ColorsController.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [CustomersController.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/WebAPI/Controllers/CustomersController.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [RentalsController.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/WebAPI/Controllers/RentalsController.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [UsersController.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/WebAPI/Controllers/UsersController.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [PowersController.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/WebAPI/Controllers/PowersController.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [AuthController.cs](https://github.com/mustafasameturan/RentACarProject/blob/master/WebAPI/Controllers/AuthController.cs) <br><br>



## ☑️SQL Tables

<table>
  <tr>
    <td>Cars</td>
     <td>Brands</td>
     <td>Colors</td>
     <td>Powers</td>
  </tr>
  <tr>
    <td>

Variable Name | Data Type
------------ | -------------
CarId | int
BrandId | int
ColorId | int
ModelYear | nchar(10)
DailyPrice | decimal
Description | nvchar(30)
Model | nchar(20)
   
   </td>
    <td>

Variable Name | Data Type
------------ | -------------
ColorId | int
ColorName | nchar(10)
   
   </td>
    <td>

Variable Name | Data Type
------------ | -------------
BrandId | int
BrandName | nchar(12)
   
   </td>
   <td>
  
Variable Name | Data Type
--------------|--------------
PowerId | int
BrandId | int
CarId | int
HorsePower | nchar(4)  
  
   </td>
  </tr>
 </table>
 
 <table>
  <tr>
    <td>Customers</td>
     <td>Rentals</td>
     <td>Users</td>
  </tr>
  <tr>
    <td>

Variable Name | Data Type
------------ | -------------
CustomerId | int
UserId | int
CompanyName | nchar(40)
   
   </td>
    <td>

Variable Name | Data Type
------------ | -------------
RentalId | int
CarId | int
CustomerId | int
RentDate | datetime
ReturnDate | datetime

   </td>
    <td>

Variable Name | Data Type
------------ | -------------
UserId | int
FirstName | nchar(25)
LastName | nchar(20)
Email | nchar(50)
Password | nchar(20)

   </td>
  </tr>
 </table>
 
 <table>
  <tr>
    <td>Users</td>
     <td>OperationClaims</td>
     <td>UserOperationClaims</td>
  </tr>
  <tr>
    <td>

Variable Name | Data Type
------------ | -------------
ıd | int
FirsName | varchar(50)
LastName | varchar(50)
Email | varchar(50)
PasswordHash | varbinary(500)
PasswordSalt | varbinary(500)
Status | bit


   </td>
    <td>

Variable Name | Data Type
------------ | -------------
Id | int
Name | varchar(250)


   </td>
    <td>

Variable Name | Data Type
------------ | -------------
Id | int
UserId | int
OperationClaimId | int


   </td>
  </tr>
 </table>
