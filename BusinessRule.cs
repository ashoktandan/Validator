using System;
using System.Collections.Generic;

namespace asynctest
{
    public  class BusinessRule
    {
        public string ErrorMessage { get; private set; }
        public string PropertyName { get; private set; }
        public DomainObject domainObject;
        public BusinessRule(DomainObject doo,string propertyName , string errorMessage)
        {
            domainObject=doo;
            ErrorMessage = errorMessage;
            PropertyName = propertyName;
        }
       // public abstract bool Check();
    }
}
