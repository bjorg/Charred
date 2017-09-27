using System;
using System.Globalization;

namespace Charred {
    public struct Str {

        //--- Class Fields ---
        private static readonly CompareInfo c = CultureInfo.InvariantCulture.CompareInfo;

        //--- Fields ---
        private string _text;
        private int _start;
        private int _count;

        //--- Constructors ---
        public Str(string text) : this(text, 0, text.Length) { }

        public Str(string text, int start, int count) {
            if(text == null) {
                throw new ArgumentNullException("text");
            }
            if((start < 0) || (start >= text.Length)) {
                throw new ArgumentOutOfRangeException("start");
            }
            if((count < 0) || ((start + count) > text.Length)) {
                throw new ArgumentOutOfRangeException("count");
            }
            _text = text;
            _start = start;
            _count = count;
        }

        //            text.Contains("foo");
        //            text.EndsWith("foo");
        //            text.Equals("foo");
        //            text.GetEnumerator();
        //            text.GetHashCode();
        //            text.IndexOf("foo");
        //            text.IndexOfAny(new[] { 'a' });
        //            text.Insert(0, "foo");
        //            text.LastIndexOf("foo");
        //            text.LastIndexOfAny(new[] { 'a' });
        //            text.PadLeft(5);
        //            text.PadRight(5);
        //            text.Remove(1, 2);
        //            text.Replace("a", "b");
        //            text.StartsWith("foo");
        //            text.Substring(2);
        //            text.ToCharArray();
        //            text.ToLower();
        //            text.ToLowerInvariant();
        //            text.ToString();
        //            text.ToUpper();
        //            text.ToUpperInvariant();
        //            text.Trim();
        //            text.TrimEnd();
        //            text.TrimStart();

        //--- Properties ---
        public int Length { get { return _count; } }

        //--- Methods ---
        public bool Contains(string value) {
            return c.IndexOf(_text, value, _start, _count);
        }
    }
}

