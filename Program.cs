using System;

namespace GenericFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1 =  MaxInteger.intMax(3, 67, 43);
            Console.WriteLine("the greatest amongst integer is : "+ var1);

            float var2 = MaxFloat.floatMax(45.6f, 56.7f, 23.7f);
            Console.WriteLine("the greatest amongst float is : " + var2);

            string var3 = MaxString.stringMax("Apple", "Banana", "Peach");
            Console.WriteLine("the greatest among integer is : " + var3);


            int variable1 =  MaxWithGenerics.MaxGenerics<int>(3, 67, 43);
            Console.WriteLine("the greatest amongst integer with generic feature is : " + variable1);

            float variable2 = MaxWithGenerics.MaxGenerics<float>(56.3f, 120.67f, 43.6f);
            Console.WriteLine("the greatest amongst flaot with generics feature is : " + variable2);

            string variable3 = MaxWithGenerics.MaxGenerics<string>("Apple", "Banana", "Peach");
            Console.WriteLine("the greatest amongst string with generic feature is : " + variable3);

            int[] intArray = { 112, 465, 890, 327, 432 };
            GenericMaximumWithClass<int> genericInt = new GenericMaximumWithClass<int>(intArray);
            genericInt.PrintMaxValue();

            float[] fltArray = { 238.45f, 567.84f, 3784.34f, 8993.23f };
            GenericMaximumWithClass<float> genericFloat = new GenericMaximumWithClass<float>(fltArray);
            genericFloat.PrintMaxValue();


            string[] stringArray = { "Apple", "Banana", "Lichi", "Peach" };
            GenericMaximumWithClass<string> genericString = new GenericMaximumWithClass<string>(stringArray);
            genericString.PrintMaxValue();

            
            GenericClassTkng3Prmtrs<int> para1 = new GenericClassTkng3Prmtrs<int>(10, 20, 30);
            Console.WriteLine("Greatest amongst 3 integer with generic Class is : " +para1.MaxMethod());

            GenericClassTkng3Prmtrs<float> para2 = new GenericClassTkng3Prmtrs<float>(254.57f, 5786.34f, 79485.56f);
            Console.WriteLine("Greatest amongst 3 float with generic Class is : " + para2.MaxMethod());

            GenericClassTkng3Prmtrs<string> para3 = new GenericClassTkng3Prmtrs<string>("Apple", "Banana", "Leach");
            Console.WriteLine("Greatest amongst 3 string with generic Class is : " + para3.MaxMethod());




        }



    }
}
