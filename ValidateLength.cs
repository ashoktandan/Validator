using System;
namespace asynctest
{
  public  interface IValidation {
         bool IsValid(DomainObject dom,string property);
    }

    public class ValidateLength: IValidation
    {
        public bool IsValid(DomainObject dom,string property) {
            string value = dom.GetType().GetProperty(property).GetValue(dom,null).ToString();
            return value.Length > 0 ? true : false;
        }
    }
}
