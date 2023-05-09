using EntityLayer.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class KayıtValidator : AbstractValidator<Kullanici>
    {
        public KayıtValidator()
        {
            RuleFor(x => x.AdSoyad).NotEmpty().WithMessage("Ad Soyad Boş Geçilemez!");
            RuleFor(x => x.TCNO).NotEmpty().WithMessage("TC Kimlik Numarası Boş Geçilemez!");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail Boş Geçilemez!");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre Boş Geçilemez!");
            RuleFor(x => x.Cinsiyet).NotEmpty().WithMessage("Lütfen Bir Cinsiyet Seçiniz!");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen Bir Resim Dosyası Yükleyiniz!");
            RuleFor(x => x.Unvan).NotEmpty().WithMessage("Lütfen Bir Ünvan Seçiniz!");

            RuleFor(x => x.AdSoyad).MaximumLength(30).WithMessage("Ad Soyad Maximum 30 Karakter İçermelidir!");
            RuleFor(x => x.AdSoyad).MinimumLength(5).WithMessage("Ad Soyad Mininmum 5 Karakter İçermelidir!");

            RuleFor(x => x.TCNO).MaximumLength(30).WithMessage("TC kimlik numaranız 11 rakamdan oluşmalıdır!");
            RuleFor(x => x.TCNO).MinimumLength(5).WithMessage("TC kimlik numaranız 11 rakamdan oluşmalıdır!");
            RuleFor(x => x.TCNO).Must(BeNumeric).WithMessage("TC No Olarak sadece rakam girilmelidir.");

            RuleFor(x => x.Mail).MaximumLength(50).WithMessage("Mailiniz Maximum 50 Karakter İçermelidir!");
            RuleFor(x => x.Mail).MinimumLength(15).WithMessage("Mailiniz Mininmum 15 Karakter İçermelidir!");

            RuleFor(x => x.Password).MinimumLength(6).WithMessage("Lütfen en az 6 hane içeren şifrenizi giriniz!");
            RuleFor(x => x.Password).MaximumLength(15).WithMessage("Lütfen en fazla 15 hane içeren şifrenizi giriniz!");

            RuleFor(x => x.OgrenciNo).MaximumLength(30).WithMessage("TC kimlik numaranız 11 rakamdan oluşmalıdır!");
            RuleFor(x => x.OgrenciNo).MinimumLength(5).WithMessage("TC kimlik numaranız 11 rakamdan oluşmalıdır!");
            RuleFor(x => x.OgrenciNo).Must(BeNumeric).WithMessage("TC No Olarak sadece rakam girilmelidir.");

            RuleFor(x => x.AdminNo).MaximumLength(30).WithMessage("TC kimlik numaranız 11 rakamdan oluşmalıdır!");
            RuleFor(x => x.AdminNo).MinimumLength(5).WithMessage("TC kimlik numaranız 11 rakamdan oluşmalıdır!");
            RuleFor(x => x.AdminNo).Must(BeNumeric).WithMessage("TC No Olarak sadece rakam girilmelidir.");

            RuleFor(x => x.PersonelNo).MaximumLength(30).WithMessage("TC kimlik numaranız 11 rakamdan oluşmalıdır!");
            RuleFor(x => x.PersonelNo).MinimumLength(5).WithMessage("TC kimlik numaranız 11 rakamdan oluşmalıdır!");
            RuleFor(x => x.PersonelNo).Must(BeNumeric).WithMessage("TC No Olarak sadece rakam girilmelidir.");
        }


        private bool BeNumeric(string arg)
        {
            return int.TryParse(arg, out int result);
        }
    }
}
