using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace prjfirstapplication
{
    class ArrayEG
    
   
        {
            //by default access specifier for member and member function is private

            //single dimensional array
            //datatype[] arrayname=new datatype[size]

            string[] fruits = new string[3];
            int[] mark = { 89, 78, 90 };

            internal void GetFruits()
            {
                for (int i = 0; i < fruits.Length; i++)
                {
                    Console.WriteLine("enter fruit name");
                    fruits[i] = Console.ReadLine();
                }
                //foreach (string fu in fruits)
                //implicity typed variable
                foreach (var fu in fruits)
                {
                    Console.WriteLine("FruitName:{0}", fu);
                }
            }
        }
        class StringEG
        {
            internal void StringFunctionEg()
            {
                string Firstname = "Sai";
                string Name = "Pooja Kamrani";
                Console.WriteLine("TO UPPER:{0}", Firstname.ToLower());
                Console.WriteLine("TO Lower:{0}", Firstname.ToUpper());
                Console.WriteLine("Length:{0}", Name.Length);
                bool isContains = Name.Contains("UP");
                Console.WriteLine("contains UP:{0}", isContains);
                Console.WriteLine("substring:{0}", Name.Substring(3, 5));


            }
        }
        class Array
        {

            static void Main()
            {
                ArrayEG arrayEg = new ArrayEG();
                arrayEg.GetFruits();

                StringEG stringEG = new StringEG();
                stringEG.StringFunctionEg();



            }
        }

    }


