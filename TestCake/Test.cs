using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Cake;

namespace cake.Test
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void additionTest()
        {
            Class1 cake = new Class1();
            Assert.AreEqual(2, cake.add(1, 1));
        }

        [Test]
        public void soustractionTest()
        {
            Class1 cake = new Class1();
            Assert.AreEqual(2, cake.less(3, 1));
        }
    }
}
