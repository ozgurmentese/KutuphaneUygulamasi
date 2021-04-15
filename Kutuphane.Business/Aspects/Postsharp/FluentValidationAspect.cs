using FluentValidation;
using Kutuphane.Business.Utilities;
using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Business.Aspects.Postsharp
{
    [Serializable]
    public class FluentValidationAspect:OnMethodBoundaryAspect
    {
        Type _validatorType;
        public FluentValidationAspect(Type validatorType)
        {
            _validatorType = validatorType;
        }


        /// <summary>
        /// OnEntry Methodun girişinde kullan 
        /// </summary>
        /// <param name="args"></param>
        public override void OnEntry(MethodExecutionArgs args)
        {
            //(IValidator) validator obje türünde değil de Ivalidator türünde olması için yazıldı
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            //ProductValidatior: AbstractValidator<Product>
            //ProductValidatior un base sınıfının birinci argumanını getir
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            //args çalıştırılan metod hakkında bilgi almamızı sağlar
            //Where(tüm argümanlarını parametrelerini gez veri tipini al eğer o tip entityType a eşitse entities e atama yap
            //örneğin Add metodunun parametre tüm paramatrelerini entities e ekle
            var entities = args.Arguments.Where(t => t.GetType() == entityType);

            //var validator = (IValidator)Activator.CreateInstance(_validatorType);
            //if (_validatorType.BaseType is null) return;
            //var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            //var entities = args.Arguments.Where(t => t.GetType() == entityType);

            //ValidatorToll: CrossCuttingConcerns.Validation.FluentValidation.ValidatorToll.cz 
            //Gönderlen validator tipini(örneğin Product) ve parametre yazısına göre ValidatorTool.FluentValidate da validate et

            foreach (var entity in entities)
            {
                ValidationTools.Validate(validator, entity);
            }

        }
    }
}
