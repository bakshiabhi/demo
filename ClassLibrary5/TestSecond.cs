using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;      
using NUnit.Framework.Internal;

namespace ClassLibrary5
{

    [TestFixture]
    public class TestSecond


    {
        [Test]
        public void add_2_numbers()
        {


            var obj1 = new ClassAdd();
            int sum = obj1.Add(7, 8);

            Assert.AreEqual(15, sum);

        }

        [Test]
        [TestCase(11, 5, 16)]
        [TestCase(100, 50, 150)]


        public void add_3_numbers_new_method(int i, int i1, int i2)
        {
            var wow = new ClassAdd();
            int simho = wow.Add(i, i1);
            Assert.AreEqual(i2, simho);

        }

        [Test]
        public void twice_done()
        {
            var need = new Classmultiply();
            int sum = need.Multiply(3, 4);

            Assert.AreEqual(12, sum);


        }

        [Test]
        [TestCase(3, 3, 9)]
        [TestCase(4, 4, 16)]
        public void many_together(int z, int x, int y)
        {
            var teeth = new Classmultiply();
            int kindff = teeth.Multiply(z, x);
            Assert.AreEqual(y, kindff);

        }

        [Test]
        public void tell_me_3()

        {
            var kidney = new classSub();
            int liver = kidney.Subs(3, 3);
        }

        [Test]
        [TestCase(5, 2, 3)]
        [TestCase(7, 3, 4)]

        public void I_green_mango_more(int e, int j, int s)

        {
            var jadu = new ClassAdd();

            int kite = jadu.Add(j, s);
            Assert.AreEqual(e, kite);
        }


        [Test]
        public void add_2_numbers_againsame()
        {

            var firstNumber = 1;
            var secondNumber = 2;
            var sum = firstNumber + secondNumber;

            Assert.AreEqual(3, sum);
        }

        [Test]

        public void aaaabbbbc_add()

        {

            var objt = new ClassFew();
            var sumrata = objt.Add(3, 6);

            Assert.AreEqual(9, sumrata);






        }
        [Test]
       [TestCase(9, 3, 6)]
        [TestCase(9, 5, 4)]


        public void sadatuje( int ty , int newnu , int oldnew)
        {


            var objy = new ClassAdd();
            var totaly = objy.Add(newnu, oldnew);

            Assert.AreEqual(totaly, ty);
        }





    }
}

    
  
            
        
        
    


