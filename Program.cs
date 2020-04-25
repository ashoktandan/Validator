using System;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;

namespace asynctest
{
    class test {
        public int MyProperty { get; set; }
        public String MyProperty0 { get; set; }
        //[DataType(DataType.Date)]
        public DateTime MyProperty1 { get; set; }
    }
 
    class Program
    {
        private static object GetPropertyValue(object obj, string property)
        {
            System.Reflection.PropertyInfo propertyInfo = obj.GetType().GetProperty(property);
            return propertyInfo.GetValue(obj, null);
        }
        void ltask() {
            for (int i = 0; i < 10000; i++) {
                Console.WriteLine(i.ToString());
            }
        }
        static async Task Main(string[] args)
        {
            var p = new Person() { Name = "" };
           bool ivalid= p.IsValid();
            var errs = p.err;
            //var validator = new PersonValidator(p);
            //if (!validator.Validate()) {
            //    var errors = validator.errors;
            //}

            //return;

            var pr = new Program();
            var t1 = Task.Run(()=>pr.ltask());
            var t2 = Task.Run(()=>pr.ltask());

            Stopwatch sw = new Stopwatch();
            sw.Start();
             t1.Wait();  t2.Wait();
             //Task.WhenAll(t1,t2).Wait();
            sw.Stop();
            Console.WriteLine(":::>>>"+sw.ElapsedMilliseconds);
            // Expression selector = Expression.Property(param, typeof(test).GetProperty("MyProperty"));
            // Expression pred = Expression.Lambda(selector, param);

            //var data = new test[] { new test{MyProperty=1,MyProperty0="AAAA",MyProperty1=DateTime.Now },
            //new test { MyProperty = 2,MyProperty0="BBBB", MyProperty1 = DateTime.Now } };
            // var result = data.ToList().OrderByDescending(c=>GetPropertyValue(c, "MyProperty1")).ToList();
            //var adata = data.ToList().Select(zzz.CreateNewStatement<test,string>("Field1, Field2"));
            // Program p = new Program();

            //  p.longop();
            Console.Read();
        }
        public async void longop(){
            int a=await Task.Run(() =>
                test()
            );
                           Console.WriteLine("longop"+a);
        }
        public int test(){
            Console.WriteLine("test atart");
           
                for (var i = 0; i < 100000000;i++){
                    Console.Write('.');
                }
           Console.WriteLine("test stop");

            //await a;
            //return Task.WaitAll();
            return 1;
        }
    }
}
