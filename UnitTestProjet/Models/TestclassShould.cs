using pProjetSynthèse.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjet.Models
{
    public class TestclassShould
    {
        [Fact]
        public void TestTrue()
        {
            Assert.True(true);
        }

        [Theory]
        [InlineData(115, 100)]
        [InlineData(115.69, 100.60)]
        [InlineData(0, 0)]
        public void calculTaxe(float expected,float x)
        {
            cMath math = new cMath();
            float returnedTaxe = cMath.CalculTaxes(x);
            Assert.Equal(expected, returnedTaxe);
        }
        [Theory]
        [InlineData(10.60, 21, 10.4)]
        [InlineData(0, 50, 50)]
        [InlineData(10, 10.60, 0.60)]
        [InlineData(0, 0, 0)]
        public void calculProfit(float expected,float profit, float cout)
        {
            cMath Profit = new cMath();
            float returnedProfit = cMath.CalculProfit(profit, cout);
            Assert.Equal(expected, returnedProfit);
        }

    }
}
