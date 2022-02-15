using System;
using System.IO;
using FFX_FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;
/// <summary>
/// Unit Test for FizzBuzz
/// Developer : S.Sathiyan 
/// </summary>
namespace FFX_FizzBuzz_UnitTest
{
    [TestClass]
    public class FizzBuzzUnitTest
    {

        [TestMethod("Unit Test until 16")]
        public void FizzBuzzTestMethodAll()
        {
            
            StringWriter output = new StringWriter();
            Console.SetOut(output);
            FizzBuzz.RunFizzBuzz(16);
            string console = output.ToString();
            Assert.AreEqual(string.Format("1{0}2{0}fizz{0}4{0}buzz{0}fizz{0}7{0}8{0}fizz{0}buzz{0}11{0}fizz{0}13{0}14{0}fizzbuzz{0}16{0}", Environment.NewLine), console);
        }
    }
}
