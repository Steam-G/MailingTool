using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPM
{
	class Program
	{
		static void Main(string[] args)
		{
			string htmlSource = File.ReadAllText(@"C:\Workspace\testmail.html");
			PreMailer.Net.PreMailer pm;
			string premailedOutput = pm.MoveCssInline(htmlSource, false);
			///string premailedOutput = pm.MoveCssInline(false,htmlSource)
		}
	}
}
