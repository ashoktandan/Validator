using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace asynctest
{
        public class Validator<T>
        {
       public List<string> errors = new List<string>();
        Dictionary<BusinessRule, IValidation> validators = new Dictionary<BusinessRule, IValidation>();
        public void Add(BusinessRule rule, IValidation validator) {
            validators.Add(rule, validator);
        }

        public bool Validate() {
            foreach (var validate in validators) {
                if (!validate.Value.IsValid(validate.Key.domainObject , validate.Key.PropertyName)) {
                    errors.Add(validate.Key.ErrorMessage);
                }
            }
            return errors.Count>0?false:true;
        }
        }
}
