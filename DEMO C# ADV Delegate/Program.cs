using DEMO_C__ADV_Delegate;

namespace demo_delegate
{
    class Program
    {
        // step 0 :
        // declare delegate : 
        //new class [Delegate]
        public delegate int StringFuncDelegate(string str);



        static void Main(string[] args)
        {



            //step 1 : 
            // dclare refrence from delegate : 
            StringFuncDelegate stringFuncDelegate;

            // step 2 : 
            // intialize refrence from delegate : 
            // Pointer to address functions (getcount...)
            ///stringFuncDelegate = new StringFuncDelegate(StringFunction.GetCountOfUpperCase);
            // syntax sugar : 
            stringFuncDelegate = StringFunction.GetCountOfUpperCase;

            // step 3 :
            // [call Method]
            // to run this merthod : 
            int result = stringFuncDelegate.Invoke("HesHam FatHy");
            Console.WriteLine($"number of upper case : {result}");  // 4 


            // to add another funtction to delegate : 
            stringFuncDelegate += StringFunction.GetCountOfLowerCase;

            result = stringFuncDelegate.Invoke("hEShAM FAThY");     // 3
            Console.WriteLine($"number of lower case : {result}");


            // to remove function from delegate : 
            stringFuncDelegate -= StringFunction.GetCountOfLowerCase;







            #region Example 1 of delegate 

            int[] numbers = { 15, 02, 39, 47, 55, 64, 75 };
            // sorting asec : 
            SortingAlgorithms<int>.BubleSort(numbers, CompareFunctions.CompareGreat);


            // sorting Desc :
            SortingAlgorithms<int>.BubleSort(numbers, CompareFunctions.CompareLess);
            #endregion



            #region Example 2 of generic delegate 
            // print name in asec : 
            string[] Names = { "hesham", "ahmed", "maha", "mai", "khaled", "ellen" };
            SortingAlgorithms<string>.BubleSort(Names, CompareFunctions.SortAsec); 
            foreach(string name in Names)
            {
                Console.WriteLine(name);
            }

            // print names in Desc : 
            SortingAlgorithms<string>.BubleSort(Names, CompareFunctions.SortDesc);
            foreach (string name in Names )
            {
                Console.WriteLine(name);
            }

            #endregion




            #region Built-In Function Deleget 

            /*
             * Predicate .. can refer to function that can take one parametermust be return bool 
             * Func      .. can refer to function that can take [0-16] parameter and must return boolean
             * Action    .. can refer to function take [0-16] parameter and must be Void 
             */


            #endregion




        }
    }
}