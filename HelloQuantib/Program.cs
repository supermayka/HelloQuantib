using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloQuantib
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Quantib!");

            string statusFile = "..\\Status\\status.json";
            string outputPath = "..\\output";
            string inputPath = "..\\input";
            string statusFormat = @"status:{0},description:{1}";
            string status = "success";
            string errorMsg = "";

            if (!Directory.Exists(outputPath))
            {
                errorMsg = "Output folder is missing";
                status = "failure";
            }
            else if(!Directory.Exists(inputPath))
            {
                errorMsg = "Input folder is missing";
                status = "failure";
            }
           
            status = string.Format(statusFormat, status, errorMsg);
            JsonFileUtils.SimpleWrite(status, statusFile);
        }

        

    }
}
