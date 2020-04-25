using System;
namespace asynctest
{
    public class PersonValidator:Validator<Person>
    {
        public PersonValidator(Person person)
        {
            Add(new BusinessRule(person, "Name","Name is required"), new ValidateLength());
        }
    }
}
