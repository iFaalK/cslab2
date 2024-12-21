using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoneySumLibrary;

namespace MoneySumLibraryTest
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void Money_DefaultConstructorTest()
        {
            Money money = new Money();
            Assert.AreEqual(0, money.Sum);
            Assert.AreEqual("USD", money.Currency);
            Assert.AreEqual(1, money.ExRate);
        }

        [TestMethod()]
        public void Money_ParameterizedConstructorTest()
        {
            Money money = new Money(100, "EUR", 1.1);
            Assert.AreEqual(110, money.Sum);
            Assert.AreEqual("USD", money.Currency);
            Assert.AreEqual(1, money.ExRate);
        }
        [TestMethod]
        public void Money_NoConversionTest()
        {
            var money = new Money(100, "USD", 1);

            Assert.AreEqual(100, money.Sum);
            Assert.AreEqual("USD", money.Currency);
            Assert.AreEqual(1, money.ExRate);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Money money = new Money(100, "USD", 1);
            Assert.AreEqual("Sum: 100 USD (original currency: USD, Exchange Rate: 1)", money.ToString());
        }

        [TestMethod()]
        public void EqualsTest()
        {
            Money money1 = new Money(100, "USD", 1);
            Money money2 = new Money(100, "USD", 1);
            Assert.IsTrue(money1.Equals(money2));
        }

        [TestMethod()]
        public void GetHashCodeTest()
        {
            Money money1 = new Money(100, "USD", 1);
            Money money2 = new Money(100, "USD", 1);
            Assert.AreEqual(money1.GetHashCode(), money2.GetHashCode());
        }

        [TestMethod()]
        public void Operator_AdditionTest()
        {
            Money money1 = new Money(100, "USD", 1);
            Money money2 = new Money(50, "USD", 1);
            Money result = money1 + money2;
            Assert.AreEqual(150, result.Sum);
        }

        [TestMethod()]
        public void Operator_AdditionWithDoubleTest()
        {
            Money money = new Money(100, "USD", 1);
            Money result = money + 50;
            Assert.AreEqual(150, result.Sum);
        }

        [TestMethod()]
        public void Operator_SubtractionTest()
        {
            Money money1 = new Money(100, "USD", 1);
            Money money2 = new Money(50, "USD", 1);
            Money result = money1 - money2;
            Assert.AreEqual(50, result.Sum);
        }

        [TestMethod()]
        public void Operator_SubtractionWithDoubleTest()
        {
            Money money = new Money(100, "USD", 1);
            Money result = money - 50;
            Assert.AreEqual(50, result.Sum);
        }

        [TestMethod()]
        public void Operator_ComparisonTest()
        {
            Money money1 = new Money(100, "USD", 1);
            Money money2 = new Money(50, "USD", 1);
            Assert.IsTrue(money1 > money2);
            Assert.IsFalse(money1 < money2);
            Assert.IsTrue(money1 >= money2);
            Assert.IsFalse(money1 <= money2);
        }

        [TestMethod()]
        public void Operator_EqualityTest()
        {
            Money money1 = new Money(100, "USD", 1);
            Money money2 = new Money(100, "USD", 1);
            Money money3 = new Money(50, "USD", 1);
            Assert.IsTrue(money1 == money2);
            Assert.IsTrue(money1 != money3);
        }

        [TestMethod()]
        public void ExplicitConversionTest()
        {
            Money money = new Money(100, "USD", 1);
            double sum = (double)money;
            Assert.AreEqual(100, sum);
        }

        [TestMethod()]
        public void ImplicitConversionTest()
        {
            Money money = 100.0;
            Assert.AreEqual(100, money.Sum);
            Assert.AreEqual("USD", money.Currency);
        }
    }
}
