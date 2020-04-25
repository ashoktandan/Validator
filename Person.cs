using System;
using System.Collections.Generic;

namespace asynctest
{
    public interface DomainObject { }
    public partial class Person: DomainObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Document { get; set; }
        public DateTime BornAt { get; set; }
    }
    public partial class Person {
        public List<string> err = new List<string>();
        public bool IsValid() {
            var v = new PersonValidator(this);
            bool bv = v.Validate();
            if (!bv) {
                err = v.errors;
            }
            return bv;
        }
    }
}
