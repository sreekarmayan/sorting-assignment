using NUnit.Framework;
using AssignmentPW.Core;
using System;

namespace AssignmentPW.Tests
{
    public class IntegerSorterTests
    {
        [Test]
        public void Sort_NormalNumbers()
        {
            int[] input = { 3, 5, 1, 4, 2 };
            int[] expected = { 1, 2, 3, 4, 5 };

            var result = IntegerSorter.Sort(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Sort_WithDuplicates()
        {
            int[] input = { 3, 3, 2, 2, 1, 1, 4 };
            int[] expected = { 1, 1, 2, 2, 3, 3, 4 };

            var result = IntegerSorter.Sort(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Sort_EmptyArray()
        {
            int[] input = { };
            int[] expected = { };

            var result = IntegerSorter.Sort(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Sort_SingleElement()
        {
            int[] input = { 11 };
            int[] expected = { 11 };

            var result = IntegerSorter.Sort(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Sort_NegativeNumbers()
        {
            int[] input = { -3, -1, -2, -4 };
            int[] expected = { -4, -3, -2, -1 };

            var result = IntegerSorter.Sort(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Sort_AlreadySorted()
        {
            int[] input = { 1, 2, 3, 4 };
            int[] expected = { 1, 2, 3, 4 };

            var result = IntegerSorter.Sort(input);

            Assert.That(result, Is.EqualTo(expected));
        }

         
        [Test]
        public void Sort_NullInput_ThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() => IntegerSorter.Sort(null));
        }

        
        [Test]
        public void Sort_AllSameValues()
        {
            int[] input = { 7, 7, 7, 7 };
            int[] expected = { 7, 7, 7, 7 };

            var result = IntegerSorter.Sort(input);

            Assert.That(result, Is.EqualTo(expected));
        }

         
        [Test]
        public void Sort_LargeNumbers()
        {
            int[] input = { 1321, -1234, 500, 0 };
            int[] expected = { -1234, 0, 500, 1321 };

            var result = IntegerSorter.Sort(input);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}