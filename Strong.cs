
using System;
using System.Collections;
using System.Collections.Generic;

namespace Strongs
{
	public class Strong : IEnumerable<char>, IEnumerable, ICloneable, IComparable, IComparable<string>, IConvertible, IEquatable<string>
	{
		private Strong() { }

		private string value;

		public static implicit operator Strong(string v)
		{
			return new Strong
			{
				value = v.ToUpperInvariant()
			};
		}

		public static implicit operator string(Strong strong)
		{
			return strong.value;
		}

		public object Clone()
		{
			return value.Clone();
		}

		public int CompareTo(object obj)
		{
			return value.CompareTo(obj);
		}

		public int CompareTo(string other)
		{
			return value.CompareTo(other);
		}

		public bool Equals(string other)
		{
			return value.Equals(other);
		}

		public IEnumerator GetEnumerator()
		{
			return ((IEnumerable)value).GetEnumerator();
		}

		public TypeCode GetTypeCode()
		{
			return value.GetTypeCode();
		}

		public bool ToBoolean(IFormatProvider provider)
		{
			return ((IConvertible)value).ToBoolean(provider);
		}

		public byte ToByte(IFormatProvider provider)
		{
			return ((IConvertible)value).ToByte(provider);
		}

		public char ToChar(IFormatProvider provider)
		{
			return ((IConvertible)value).ToChar(provider);
		}

		public DateTime ToDateTime(IFormatProvider provider)
		{
			return ((IConvertible)value).ToDateTime(provider);
		}

		public decimal ToDecimal(IFormatProvider provider)
		{
			return ((IConvertible)value).ToDecimal(provider);
		}

		public double ToDouble(IFormatProvider provider)
		{
			return ((IConvertible)value).ToDouble(provider);
		}

		public short ToInt16(IFormatProvider provider)
		{
			return ((IConvertible)value).ToInt16(provider);
		}

		public int ToInt32(IFormatProvider provider)
		{
			return ((IConvertible)value).ToInt32(provider);
		}

		public long ToInt64(IFormatProvider provider)
		{
			return ((IConvertible)value).ToInt64(provider);
		}

		public sbyte ToSByte(IFormatProvider provider)
		{
			return ((IConvertible)value).ToSByte(provider);
		}

		public float ToSingle(IFormatProvider provider)
		{
			return ((IConvertible)value).ToSingle(provider);
		}

		public string ToString(IFormatProvider provider)
		{
			return value.ToString(provider);
		}

		public object ToType(Type conversionType, IFormatProvider provider)
		{
			return ((IConvertible)value).ToType(conversionType, provider);
		}

		public ushort ToUInt16(IFormatProvider provider)
		{
			return ((IConvertible)value).ToUInt16(provider);
		}

		public uint ToUInt32(IFormatProvider provider)
		{
			return ((IConvertible)value).ToUInt32(provider);
		}

		public ulong ToUInt64(IFormatProvider provider)
		{
			return ((IConvertible)value).ToUInt64(provider);
		}

		IEnumerator<char> IEnumerable<char>.GetEnumerator()
		{
			return ((IEnumerable<char>)value).GetEnumerator();
		}
	}
}
