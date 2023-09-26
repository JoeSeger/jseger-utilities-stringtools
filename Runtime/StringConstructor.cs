using System;
using System.Text;

namespace JSeger.Utilities.Stringtools.Runtime
{
    public struct StringConstructor
    {
        private StringBuilder _stringBuilder;

        public StringConstructor Append(string str)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));

            _stringBuilder ??= new StringBuilder();
            
            _stringBuilder.Append(str);
            return this;
        }

        public StringConstructor Insert(int index, string str)
        {
            if (index < 0 || index > _stringBuilder.Length) throw new ArgumentOutOfRangeException(nameof(index));
            if (str == null) throw new ArgumentNullException(nameof(str));
        
            _stringBuilder ??= new StringBuilder();

            _stringBuilder.Insert(index, str);
            return this;
        }

        public StringConstructor Remove(int startIndex, int length)
        {
            if (startIndex < 0 || startIndex >= _stringBuilder.Length) throw new ArgumentOutOfRangeException(nameof(startIndex));
            if (length < 0 || length > _stringBuilder.Length - startIndex) throw new ArgumentOutOfRangeException(nameof(length));

            _stringBuilder ??= new StringBuilder();

            _stringBuilder.Remove(startIndex, length);
            return this;
        }

        public StringConstructor(params string[] strings)
        {
            _stringBuilder = new StringBuilder();

            if (strings == null) return;
            foreach (var str in strings)
            {
                _stringBuilder.Append(str);
            }
        }

        public override string ToString() => _stringBuilder?.ToString() ?? string.Empty;
        
    }
}