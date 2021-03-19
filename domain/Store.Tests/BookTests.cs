using System;
using Xunit;

namespace Store.Tests
{
    public class BookTests
    {
        [Fact]
        public void IsIsbn_WithNull_returnFalse()
        {
            bool actual = Book.IsIsbn(null);

            Assert.False(actual);
        }

        [Fact]
        public void IsIsbn_WithBlankString_returnFalse()
        {
            bool actual = Book.IsIsbn("    ");

            Assert.False(actual);
        }

        [Fact]
        public void IsIsbn_WithInvalideIsbn_returnFalse()
        {
            bool actual = Book.IsIsbn("ISBN 123");

            Assert.False(actual);
        }

        [Fact]
        public void IsIsbn_WithIsbn10_returnFalse()
        {
            bool actual = Book.IsIsbn("IsBn 123-456-789 0");

            Assert.True(actual);
        }

        [Fact]
        public void IsIsbn_WithIsbn13_returnFalse()
        {
            bool actual = Book.IsIsbn("IsBn 123-456-789 0123");

            Assert.True(actual);
        }

        [Fact]
        public void IsIsbn_With≈TrashStart_returnFalse()
        {
            bool actual = Book.IsIsbn("xxIsBn 123-456-789 0123cc");

            Assert.False(actual);
        }
    }
}
