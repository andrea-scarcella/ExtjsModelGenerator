using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ExtModelGenerator.Test
{
	[TestFixture]
    public class Class1
    {
		public string fileName { get; set; }
		public Assembly assembly { get; set; }

		[TestFixtureSetUp]
		public void MyTestMethod()
		{
			fileName = "";
			 assembly = Assembly.ReflectionOnlyLoadFrom(fileName);	
		}
		[SetUp]
		public void Setup() {
			

		}



		
	}
}
