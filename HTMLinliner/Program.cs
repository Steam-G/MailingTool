using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLinliner
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog();
            CreateInlineHTML();
            
            Console.ReadKey();
        }

        static string subpathCSS = @"css";
        static string subpathHTML = @"HTML";
        static string subpathHTMLinline = @"HTMLinline";

        static void Catalog()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            dirInfo.CreateSubdirectory(subpathHTML);
            dirInfo.CreateSubdirectory(subpathHTML+"/"+subpathCSS);
            dirInfo.CreateSubdirectory(subpathHTMLinline);
        }

        static void CreateInlineHTML()
        {
            var files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + subpathHTML);
            
            Uri baseURI = new Uri(AppDomain.CurrentDomain.BaseDirectory + subpathHTML + "/" + subpathCSS);
            DirectoryInfo directoryInfo = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + subpathHTML);
            foreach (var s in directoryInfo.GetFiles())
            {
                Console.WriteLine(s);
                string htmlSource = File.ReadAllText(s.FullName);
                var result = PreMailer.Net.PreMailer.MoveCssInline(baseURI, htmlSource);
                File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + subpathHTMLinline + @"\inline_" + s.Name, result.Html);
                //Console.WriteLine(result.Warnings); 	// string[] of any warnings that occurred during processing.
            }

            //Console.WriteLine(result.Html);         // Resultant HTML, with CSS in-lined.
            //Console.WriteLine(result.Warnings); 	// string[] of any warnings that occurred during processing.
            //Console.ReadKey();

            Console.WriteLine("\n Готово! Все HTML-документы объеденены с их стилями...");
        }
    }
}
