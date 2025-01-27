// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.

namespace Raygun.Tests
{
    public class RaygunTests
    {
        [Theory]
        [InlineData(5, 5)]
        public void Raygun_Fire_WillReduceCharge(int mChrg, int cChrg)
        {
            // Arrange
            TestRaygun = new Raygun(mChrg, cChrg);
            Alien = new Alien(true, 10);

            // Act
            TestRaygun.FireAt(Alien);

            // Assert
            Assert.Equal(TestRaygun.IsFullyCharged(), false);
        
        }

        [Theory]
        [InlineData(5, 4)]
        public void Raygun_ChargeMethod_WillIncreaseCharge(int mChrg, int cChrg)
        {
            // Arrange
            TestRaygun = new Raygun(mChrg, cChrg);

            // Act
            TestRaygun.Recharge();

            // Assert
            Assert.Equal(TestRaygun.IsFullyCharged(), true);
        }

    }
}
