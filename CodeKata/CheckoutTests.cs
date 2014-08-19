using System;
using NUnit;

namespace CodeKata
{
    using NUnit.Framework;

    [TestFixture]
    public class CheckoutTests
    {
        private int Price(string goods)
        {
            var checkout = new Checkout();
            foreach (var product in goods.ToCharArray())
            {
                checkout.Scan(product);
            }

            return checkout.total;
        }


        [Test]
        public void TestOne()
        {
            const string ProductCode = "A";
            

            Assert.AreEqual(50, Price(ProductCode));
        }

        [Test]
        public void TestTwo()
        {
            const string ProductCode = "";
            
            Assert.AreEqual(0, Price(ProductCode));
        }

        [Test]
        public void TestThree()
        {
            var ProductCode = "AB";
            
            Assert.AreEqual(80, Price(ProductCode));
        }

        [Test]
        public void TestFour()
        {
            var ProductCode = "CDBA";
            
            Assert.AreEqual(115, Price(ProductCode));
        }

        [Test]
        public void TestFive()
        {
            var ProductCode = "AA";
            
            Assert.AreEqual(100, Price(ProductCode));
        }

        [Test]
        public void TestSix()
        {
            var ProductCode = "AAA";
            
            Assert.AreEqual(130, Price(ProductCode));
        }

        [Test]
        public void TestSeven()
        {
            var ProductCode = "AAAA";
            
            Assert.AreEqual(180, Price(ProductCode));
        }

        [Test]
        public void TestEight()
        {
            var ProductCode = "AAAAA";
            
            Assert.AreEqual(230, Price(ProductCode));
        }

        [Test]
        public void TestNine()
        {
            var ProductCode = "AAAAAA";
            
            Assert.AreEqual(260, Price(ProductCode));
        }

        [Test]
        public void TestTen()
        {
            var ProductCode = "AAAB";
            
            Assert.AreEqual(160, Price(ProductCode));
        }

        [Test]
        public void TestEleven()
        {
            var ProductCode = "AAABB";
            
            Assert.AreEqual(175, Price(ProductCode));
        }

        [Test]
        public void TestTwelve()
        {
            var ProductCode = "AAABBD";

            Assert.AreEqual(190, Price(ProductCode));
        }

        [Test]
        public void TestThirteen()
        {
            var ProductCode = "DABABA";

            Assert.AreEqual(190, Price(ProductCode));
        }
    }
}
