//////using System;

//////class Program
//////{
//////    static void Main()
//////    {

//////        int[,] numbers =
//////        {
//////            {1, 2, 3},//,
//////            {4, 5, 6}//1;
//////        };



//////        for (int i = 0; i < numbers.GetLength(0); i++)
//////        {
//////            for (int j = 0; j < numbers.GetLength(1); j++)
//////            {

//////                Console.WriteLine(numbers[i, j]);
//////            }
//////        }
//////    }
//////}



////using System;

////class Program
////{
////    static void Main()
////    {

////        int[,] numbers =
////        {
////            {10, 20},
////            {30, 40}
////        };


////        int sum = 0;


////        for (int i = 0; i < numbers.GetLength(0); i++) 
////        {
////            for (int j = 0; j < numbers.GetLength(1); j++) 
////            {

////                sum += numbers[i, j];

////            }
////        }
////        Console.OutputEncoding= System.Text.Encoding.UTF8;
////        Console.WriteLine("ჯამი: " + sum);
////    }
////}

//using System;

//int[,] numbers =
//        {
//            {15, 7, 20},
//            {40, 12, 8}
//        };

//int max = numbers[0, 0];

//for (int i = 0; i < numbers.GetLength(0); i++) 
//{
//    for (int j = 0; j < numbers.GetLength(1); j++) 
//    {
        
//        if (numbers[i, j] > max)
//        {
         
//            max = numbers[i, j];
//        }
//    }
//}
//Console.OutputEncoding = System.Text.Encoding.UTF8;
//Console.WriteLine("მაქსიმალური ელემენტია: " + max);

