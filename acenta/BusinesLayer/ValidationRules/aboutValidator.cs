using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinesLayer.ValidationRules
{
    public class aboutValidator:AbstractValidator<about>
    {
        public aboutValidator()
        {
            RuleFor(x => x.aciklama).NotEmpty().WithMessage("Açıklama kısmını boş geçemezsiniz");
            RuleFor(x=>x.resimURL1).NotEmpty().WithMessage("Lütfen resim seçiniz");
            RuleFor(x => x.aciklama).MinimumLength(50).WithMessage("Lütfen en az 50 karakterli açıklama giriniz");
            RuleFor(x=>x.aciklama).MaximumLength(1500).WithMessage("Lütfen en fazla 1500 karakterli açıklama giriniz");
        }

    }
}
