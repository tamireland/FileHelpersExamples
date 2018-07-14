using System;
using FileHelpers;
using FileHelpersLibrary;

namespace FileHelperCoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //// 1. Quick Start - Deliminated 
            //var engine = new FileHelperEngine<Customer>();
            //// To Read Use:
            //var result = engine.ReadFile("d:\\onedrive\\documents\\visual studio 2017\\Projects\\FileHelpersExamples\\FileHelperCoreConsoleApp\\Files\\FileIn.txt");
            //// result is now an array of Customer
            //// To Write Use:
            //engine.WriteFile("d:\\onedrive\\documents\\visual studio 2017\\Projects\\FileHelpersExamples\\FileHelperCoreConsoleApp\\Files\\FileOut.txt", result);
            //foreach (Customer cust in result)
            //{
            //    Console.WriteLine("Customer Info:");
            //    Console.WriteLine(cust.Name + " - " + cust.AddedDate.ToString("dd/MM/yy"));
            //}



            // 2. QuickStart - FIxed Length

            // Create a FileHelperEngine for Read and Write
            var engine = new FileHelperEngine<Customer2>();

            // To Read Use:
            var result = engine.ReadFile("d:\\onedrive\\documents\\visual studio 2017\\Projects\\FileHelpersExamples\\FileHelperCoreConsoleApp\\Files\\FileIn2.txt");
            // result is now an array of Customer

            // To Write Use:
            engine.WriteFile("d:\\onedrive\\documents\\visual studio 2017\\Projects\\FileHelpersExamples\\FileHelperCoreConsoleApp\\Files\\FileOut2.txt", result);

            // Use the resulting array
            foreach (Customer2 cust in result)
            {
                Console.WriteLine("Customer Info:");
                Console.WriteLine(cust.Name + " - " + cust.AddedDate.ToString("dd/MM/yy"));
            }




            Console.ReadLine();
        }
    }
}
