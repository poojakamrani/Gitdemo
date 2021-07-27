using System;
using System.Collections.Generic;
using System.Text;

namespace prjfirstapplication
{
    class Datatype
    {//syntax of method:accessspecifier returntype methodname(parameterlist){code}

        void Type()
        {
            String name;
            int age;
            float salary = 67900.89f;
            Console.WriteLine("Enter the name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the age");
            age = Convert.ToInt32(Console.ReadLine());
            //Placeholder
            Console.WriteLine("Name:{0} && Salary:{2}", name, age, salary);
        }
        void TypeConversion()
        {
            //Implicit type conversion
            //int<float<double
            int num = 100;
            float petrol = num;
            double disel = petrol;
            Console.WriteLine("Implicit type conversion:{0}", disel);

            //explicit type conversion
        }

        void BoxingandUnboxing()
        {
            //conversion of value type to reference type is boxing and unboxing ulta
            int salary = 20000;//value type
            Object obj = salary;//int to obj (boxing)
            int number = (int)obj;//reference to value(unboxing)
            Console.WriteLine("BoxingandUnboxing:{0}", number);
        }
        void NullableTypes()
        {
            //value Nullabletype
            //int age=null;(error)
            int? age = null;
            Console.WriteLine("Age is {0}",age??0);
            //Reference nullable type
            string? city = null;
            Console.WriteLine("city is {0}",city??"chennai");
        }

        static void Main()
        {
            Datatype datatype = new Datatype();
            datatype.Type();
            Console.WriteLine("---------");
            datatype.TypeConversion();
            Console.WriteLine("----------");
            datatype.BoxingandUnboxing();
            Console.WriteLine("----------");
            datatype.NullableTypes();
            Console.WriteLine("----------");




        }
    }
}
