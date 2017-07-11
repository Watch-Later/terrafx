// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\minwindef.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using TerraFX.Utilities;

namespace TerraFX.Interop
{
    unsafe public /* blittable */ struct WPARAM : IComparable, IComparable<WPARAM>, IEquatable<WPARAM>, IFormattable
    {
        #region Fields
        internal UINT_PTR _value;
        #endregion

        #region Constructors
        /// <summary>Initializes a new instance of the <see cref="WPARAM" /> struct.</summary>
        /// <param name="value">The <see cref="UINT_PTR" /> used to initialize the instance.</param>
        public WPARAM(UINT_PTR value)
        {
            _value = value;
        }
        #endregion

        #region Operators
        /// <summary>Computes the bitwise-complement of a <see cref="WPARAM" /> value.</summary>
        /// <param name="value">The <see cref="WPARAM" /> for which to compute the bitwise-complement.</param>
        /// <returns>The bitwise-complement of <paramref name="value" />.</returns>
        public static WPARAM operator ~(WPARAM value)
        {
            return ~value._value;
        }

        /// <summary>Increments a <see cref="WPARAM" /> value.</summary>
        /// <param name="value">The <see cref="WPARAM" /> for which to increment.</param>
        /// <returns>The increment of <paramref name="value" /></returns>
        public static WPARAM operator ++(WPARAM value)
        {
            return value._value + 1;
        }

        /// <summary>Decrements a <see cref="WPARAM" /> value.</summary>
        /// <param name="value">The <see cref="WPARAM" /> for which to decrement.</param>
        /// <returns>The decrement of <paramref name="value" /></returns>
        public static WPARAM operator --(WPARAM value)
        {
            return value._value - 1;
        }

        /// <summary>Adds two <see cref="WPARAM" /> values to compute their sum.</summary>
        /// <param name="left">The <see cref="WPARAM" /> to add with <paramref name="right" />.</param>
        /// <param name="right">The <see cref="WPARAM" /> to add with <paramref name="left" />.</param>
        /// <returns>The sum of <paramref name="left" /> and <paramref name="right" />.</returns>
        public static WPARAM operator +(WPARAM left, WPARAM right)
        {
            return left._value + right._value;
        }

        /// <summary>Subtracts two <see cref="WPARAM" /> values to compute their difference.</summary>
        /// <param name="left">The <see cref="WPARAM" /> from which to subtract <paramref name="right" />.</param>
        /// <param name="right">The <see cref="WPARAM" /> to subtract from <paramref name="left" />.</param>
        /// <returns>The difference of <paramref name="right" /> subtracted from <paramref name="left" />.</returns>
        public static WPARAM operator -(WPARAM left, WPARAM right)
        {
            return left._value - right._value;
        }

        /// <summary>Multiplies two <see cref="WPARAM" /> values to compute their product.</summary>
        /// <param name="left">The <see cref="WPARAM" /> to multiply with <paramref name="right" />.</param>
        /// <param name="right">The <see cref="WPARAM" /> to multiply with <paramref name="left" />.</param>
        /// <returns>The product of <paramref name="left" /> and <paramref name="right" />.</returns>
        public static WPARAM operator *(WPARAM left, WPARAM right)
        {
            return left._value * right._value;
        }

        /// <summary>Divides two <see cref="WPARAM" /> values to compute their quotient.</summary>
        /// <param name="left">The <see cref="WPARAM" /> that will be divided by <paramref name="right" />.</param>
        /// <param name="right">The <see cref="WPARAM" /> to divide <paramref name="left" /> by.</param>
        /// <returns>The quotient of <paramref name="left" /> divided by <paramref name="right" />.</returns>
        public static WPARAM operator /(WPARAM left, WPARAM right)
        {
            return left._value / right._value;
        }

        /// <summary>Divides two <see cref="WPARAM" /> values to compute their remainder.</summary>
        /// <param name="left">The <see cref="WPARAM" /> that will be divided by <paramref name="right" />.</param>
        /// <param name="right">The <see cref="WPARAM" /> to divide <paramref name="left" /> by.</param>
        /// <returns>The remainder of <paramref name="left" /> divided by <paramref name="right" />.</returns>
        public static WPARAM operator %(WPARAM left, WPARAM right)
        {
            return left._value % right._value;
        }

        /// <summary>Computes the bitwise AND of two <see cref="WPARAM" /> values.</summary>
        /// <param name="left">The <see cref="WPARAM" /> to bitwise AND with <paramref name="right" />.</param>
        /// <param name="right">The <see cref="WPARAM" /> to bitwise AND with <paramref name="left" />.</param>
        /// <returns>The bitwise AND of <paramref name="left" /> and <paramref name="right" />.</returns>
        public static WPARAM operator &(WPARAM left, WPARAM right)
        {
            return left._value & right._value;
        }

        /// <summary>Computes the bitwise OR of two <see cref="WPARAM" /> values.</summary>
        /// <param name="left">The <see cref="WPARAM" /> to bitwise OR with <paramref name="right" />.</param>
        /// <param name="right">The <see cref="WPARAM" /> to bitwise OR with <paramref name="left" />.</param>
        /// <returns>The bitwise OR of <paramref name="left" /> and <paramref name="right" />.</returns>
        public static WPARAM operator |(WPARAM left, WPARAM right)
        {
            return left._value | right._value;
        }

        /// <summary>Computes the bitwise XOR of two <see cref="WPARAM" /> values.</summary>
        /// <param name="left">The <see cref="WPARAM" /> to bitwise XOR with <paramref name="right" />.</param>
        /// <param name="right">The <see cref="WPARAM" /> to bitwise XOR with <paramref name="left" />.</param>
        /// <returns>The bitwise XOR of <paramref name="left" /> and <paramref name="right" />.</returns>
        public static WPARAM operator ^(WPARAM left, WPARAM right)
        {
            return left._value ^ right._value;
        }

        /// <summary>Shifts a <see cref="WPARAM" /> value left.</summary>
        /// <param name="value">The <see cref="WPARAM" /> to shift left.</param>
        /// <param name="bits">The number of bits to shift <paramref name="value"/> left by.</param>
        /// <returns>The result of shifting <paramref name="value" /> left <paramref name="bits" /> times.</returns>
        public static WPARAM operator <<(WPARAM value, int bits)
        {
            return value._value << bits;
        }

        /// <summary>Shifts a <see cref="WPARAM" /> value right.</summary>
        /// <param name="value">The <see cref="WPARAM" /> to shift right.</param>
        /// <param name="bits">The number of bits to shift <paramref name="value"/> left by.</param>
        /// <returns>The result of shifting <paramref name="value" /> right <paramref name="bits" /> times.</returns>
        public static WPARAM operator >>(WPARAM value, int bits)
        {
            return value._value >> bits;
        }

        /// <summary>Compares two <see cref="WPARAM" /> instances to determine equality.</summary>
        /// <param name="left">The <see cref="WPARAM" /> to compare with <paramref name="right" />.</param>
        /// <param name="right">The <see cref="WPARAM" /> to compare with <paramref name="left" />.</param>
        /// <returns><c>true</c> if <paramref name="left" /> and <paramref name="right" /> are equal; otherwise, <c>false</c>.</returns>
        public static bool operator ==(WPARAM left, WPARAM right)
        {
            return left._value == right._value;
        }

        /// <summary>Compares two <see cref="WPARAM" /> instances to determine inequality.</summary>
        /// <param name="left">The <see cref="WPARAM" /> to compare with <paramref name="right" />.</param>
        /// <param name="right">The <see cref="WPARAM" /> to compare with <paramref name="left" />.</param>
        /// <returns><c>true</c> if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, <c>false</c>.</returns>
        public static bool operator !=(WPARAM left, WPARAM right)
        {
            return left._value != right._value;
        }

        /// <summary>Compares two <see cref="WPARAM" /> instances to determine relative sort-order.</summary>
        /// <param name="left">The <see cref="WPARAM" /> to compare with <paramref name="right" />.</param>
        /// <param name="right">The <see cref="WPARAM" /> to compare with <paramref name="left" />.</param>
        /// <returns><c>true</c> if <paramref name="left" /> is less than <paramref name="right" />; otherwise, <c>false</c>.</returns>
        public static bool operator <(WPARAM left, WPARAM right)
        {
            return left._value < right._value;
        }

        /// <summary>Compares two <see cref="WPARAM" /> instances to determine relative sort-order.</summary>
        /// <param name="left">The <see cref="WPARAM" /> to compare with <paramref name="right" />.</param>
        /// <param name="right">The <see cref="WPARAM" /> to compare with <paramref name="left" />.</param>
        /// <returns><c>true</c> if <paramref name="left" /> is greater than <paramref name="right" />; otherwise, <c>false</c>.</returns>
        public static bool operator >(WPARAM left, WPARAM right)
        {
            return left._value > right._value;
        }

        /// <summary>Compares two <see cref="WPARAM" /> instances to determine relative sort-order.</summary>
        /// <param name="left">The <see cref="WPARAM" /> to compare with <paramref name="right" />.</param>
        /// <param name="right">The <see cref="WPARAM" /> to compare with <paramref name="left" />.</param>
        /// <returns><c>true</c> if <paramref name="left" /> is less than or equal to <paramref name="right" />; otherwise, <c>false</c>.</returns>
        public static bool operator <=(WPARAM left, WPARAM right)
        {
            return left._value <= right._value;
        }

        /// <summary>Compares two <see cref="WPARAM" /> instances to determine relative sort-order.</summary>
        /// <param name="left">The <see cref="WPARAM" /> to compare with <paramref name="right" />.</param>
        /// <param name="right">The <see cref="WPARAM" /> to compare with <paramref name="left" />.</param>
        /// <returns><c>true</c> if <paramref name="left" /> is greater than or equal to <paramref name="right" />; otherwise, <c>false</c>.</returns>
        public static bool operator >=(WPARAM left, WPARAM right)
        {
            return left._value >= right._value;
        }

        /// <summary>Explicitly converts a <see cref="WPARAM" /> value to a <see cref="uint" /> value.</summary>
        /// <param name="value">The <see cref="WPARAM" /> value to convert.</param>
        public static explicit operator uint(WPARAM value)
        {
            return (uint)(value._value);
        }

        /// <summary>Explicitly converts a <see cref="ulong" /> value to a <see cref="WPARAM" /> value.</summary>
        /// <param name="value">The <see cref="ulong" /> value to convert.</param>
        public static explicit operator nint(WPARAM value)
        {
            return (nint)(value._value);
        }

        /// <summary>Explicitly converts a <see cref="ulong" /> value to a <see cref="WPARAM" /> value.</summary>
        /// <param name="value">The <see cref="ulong" /> value to convert.</param>
        public static explicit operator WPARAM(ulong value)
        {
            return new WPARAM((nuint)(value));
        }

        /// <summary>Explicitly converts a <see cref="void" />* value to a <see cref="WPARAM" /> value.</summary>
        /// <param name="value">The <see cref="void" />* value to convert.</param>
        public static explicit operator WPARAM(void* value)
        {
            return new WPARAM((nuint)(value));
        }

        /// <summary>Explicitly converts a <see cref="WPARAM" /> value to a <see cref="void" />* value.</summary>
        /// <param name="value">The <see cref="WPARAM" /> value to convert.</param>
        public static explicit operator void* (WPARAM value)
        {
            return (void*)(value._value);
        }

        /// <summary>Implicitly converts a <see cref="WPARAM" /> value to a <see cref="ulong" /> value.</summary>
        /// <param name="value">The <see cref="WPARAM" /> value to convert.</param>
        public static implicit operator ulong(WPARAM value)
        {
            return value._value;
        }

        /// <summary>Implicitly converts a <see cref="WPARAM" /> value to a <see cref="nuint" /> value.</summary>
        /// <param name="value">The <see cref="WPARAM" /> value to convert.</param>
        public static implicit operator nuint(WPARAM value)
        {
            return value._value;
        }

        /// <summary>Implicitly converts a <see cref="WPARAM" /> value to a <see cref="UINT_PTR" /> value.</summary>
        /// <param name="value">The <see cref="WPARAM" /> value to convert.</param>
        public static implicit operator UINT_PTR(WPARAM value)
        {
            return value._value;
        }

        /// <summary>Implicitly converts a <see cref="uint" /> value to a <see cref="WPARAM" /> value.</summary>
        /// <param name="value">The <see cref="uint" /> value to convert.</param>
        public static implicit operator WPARAM(uint value)
        {
            return new WPARAM(value);
        }

        /// <summary>Implicitly converts a <see cref="nuint" /> value to a <see cref="WPARAM" /> value.</summary>
        /// <param name="value">The <see cref="nuint" /> value to convert.</param>
        public static implicit operator WPARAM(nuint value)
        {
            return new WPARAM(value);
        }

        /// <summary>Implicitly converts a <see cref="UINT_PTR" /> value to a <see cref="WPARAM" /> value.</summary>
        /// <param name="value">The <see cref="UINT_PTR" /> value to convert.</param>
        public static implicit operator WPARAM(UINT_PTR value)
        {
            return new WPARAM(value);
        }
        #endregion

        #region System.IComparable
        /// <summary>Compares a <see cref="object" /> with the current instance to determine relative sort-order.</summary>
        /// <param name="obj">The <see cref="object" /> to compare with the current instance.</param>
        /// <returns>A value <c>less than zero</c> if <paramref name="obj" /> is greater than the current instance, <c>zero</c> if <paramref name="obj"/> is equal to the current instance; and <c>greater than zero</c> if <paramref name="obj" /> is <c>null</c> or greater than the current instance.</returns>
        /// <exception cref="ArgumentException"><paramref name="obj" /> is not <c>null</c> and is not an instance of <see cref="WPARAM" />.</exception>
        public int CompareTo(object obj)
        {
            if (obj is null)
            {
                return 1;
            }
            else if (obj is WPARAM other)
            {
                return CompareTo(other);
            }
            else
            {
                throw ExceptionUtilities.NewArgumentExceptionForInvalidType(nameof(obj), obj.GetType());
            }
        }
        #endregion

        #region System.IComparable<WPARAM>
        /// <summary>Compares a <see cref="WPARAM" /> with the current instance to determine relative sort-order.</summary>
        /// <param name="other">The <see cref="WPARAM" /> to compare with the current instance.</param>
        /// <returns>A value <c>less than zero</c> if <paramref name="other" /> is greater than the current instance, <c>zero</c> if <paramref name="other"/> is equal to the current instance; and <c>greater than zero</c> if <paramref name="other" /> is greater than the current instance.</returns>
        public int CompareTo(WPARAM other)
        {
            return _value.CompareTo(other._value);
        }
        #endregion

        #region System.IEquatable<WPARAM>
        /// <summary>Compares a <see cref="WPARAM" /> with the current instance to determine equality.</summary>
        /// <param name="other">The <see cref="WPARAM" /> to compare with the current instance.</param>
        /// <returns><c>true</c> if <paramref name="other" /> is equal to the current instance; otherwise, <c>false</c>.</returns>
        public bool Equals(WPARAM other)
        {
            return _value.Equals(other._value);
        }
        #endregion

        #region System.IFormattable
        /// <summary>Converts the current instance to an equivalent <see cref="string" /> value.</summary>
        /// <param name="format">The format to use or <c>null</c> to use the default format.</param>
        /// <param name="formatProvider">The provider to use when formatting the current instance or <c>null</c> to use the default provider.</param>
        /// <returns>An equivalent <see cref="string" /> value for the current instance.</returns>
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return _value.ToString(format, formatProvider);
        }
        #endregion

        #region System.Object
        /// <summary>Compares a <see cref="object" /> with the current instance to determine equality.</summary>
        /// <param name="obj">The <see cref="object" /> to compare with the current instance.</param>
        /// <returns><c>true</c> if <paramref name="obj" /> is an instance of <see cref="WPARAM" /> and is equal to the current instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            return (obj is WPARAM other)
                && Equals(other);
        }

        /// <summary>Gets a hash code for the current instance.</summary>
        /// <returns>A hash code for the current instance.</returns>
        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }

        /// <summary>Converts the current instance to an equivalent <see cref="string" /> value.</summary>
        /// <returns>An equivalent <see cref="string" /> value for the current instance.</returns>
        public override string ToString()
        {
            return _value.ToString();
        }
        #endregion
    }
}