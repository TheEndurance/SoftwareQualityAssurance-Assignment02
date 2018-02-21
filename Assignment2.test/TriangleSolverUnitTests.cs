using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Assignment2.test
{
    [TestFixture]
    public class TriangleSolverUnitTests
    {
        [Test]
        public void TriangleSolver_WithDimensions50x20x10_ReturnsInvalid()
        {
            //arrange
            string expectedOutput = "invalid";
            //act
            string output = TriangleSolver.Analyze(50, 20, 10);
            //assert
            Assert.AreEqual(expectedOutput,output);
        }

        [Test]
        public void TriangleSolver_WithDimensions50x50x50_ReturnsEquilateral()
        {
            //arrange
            string expectedOutput = "equilateral";
            //act
            string output = TriangleSolver.Analyze(50, 50, 50);
            //assert
            Assert.AreEqual(expectedOutput,output);
        }

        [Test]
        public void TriangleSolver_WithDimensions50x50x30_ReturnsIsosceles()
        {
            //arrange
            string expectedOutput = "isosceles";
            //act
            string output = TriangleSolver.Analyze(50, 50, 30);
            //assert
            Assert.AreEqual(expectedOutput,output);
        }

        [Test]
        public void TriangleSolver_WithDimensions70x100x150_ReturnsScalene()
        {
            //arrange
            string expectedOutput = "scalene";
            //act
            string output = TriangleSolver.Analyze(70,100,150);
            //assert
            Assert.AreEqual(expectedOutput,output);
        }

        [Test]
        public void TriangleSolver_WithDimensionsNegative25x15x20_ReturnsInvalid()
        {
            //arrange
            string expectedOutput = "invalid";
            //act
            string output = TriangleSolver.Analyze(-25, -15, -20);
            //assert
            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void TriangleSolver_WithDimensions1x1x1_ReturnsEquilateral()
        {
            //arrange
            string expectedOutput = "equilateral";
            //act
            string output = TriangleSolver.Analyze(1, 1, 1);
            //assert
            Assert.AreEqual(expectedOutput,output);
        }

        [Test]
        public void TriangleSolver_WithDimensionsNegative50x50x50_ReturnsInvalid()
        {
            //arrange
            string expectedOutput = "invalid";
            //act
            string output = TriangleSolver.Analyze(-50, -50, -50);
            //assert
            Assert.AreEqual(expectedOutput,output);
        }

        [Test]
        public void TriangleSolver_WithDimensionsInt32Max_ReturnsInvalid()
        {
            //arrange
            string expectedOutput = "invalid";
            //act
            string output = TriangleSolver.Analyze(Int32.MaxValue, Int32.MaxValue, Int32.MaxValue);
            //assert
            Assert.AreEqual(expectedOutput,output);
        }

    }
}
