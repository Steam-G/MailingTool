using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PreMailer.Net;

namespace TestPM
{
	class Program
	{
		static void Main(string[] args)
		{
			string htmlSource = File.ReadAllText(@"C:\Work\Repos\MilingTool\MailingTool\EmailTemplate\simple_ru_сутки.html");
			string cssSource = File.ReadAllText(@"C:\Work\Repos\MilingTool\MailingTool\EmailTemplate\css\simple.css");
			Uri baseURI = new Uri(@"C:\Work\Repos\MilingTool\MailingTool\EmailTemplate\");
			var result = PreMailer.Net.PreMailer.MoveCssInline(baseURI, htmlSource);

			Console.WriteLine(result.Html);         // Resultant HTML, with CSS in-lined.
													//Console.WriteLine(result.Warnings); 	// string[] of any warnings that occurred during processing.
			Console.ReadKey();

			File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory+"htmlInLine.html", result.Html);
		}
	}
}
