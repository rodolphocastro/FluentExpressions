namespace FluentExpressions.Core.Tokens
{
    public class AnchorToken : BaseToken
    {
        internal AnchorToken(string value) : base(value)
        {
        }

        public static class Strings
        {
            public static AnchorToken Start => new AnchorToken(AnchorConstants._startOfString);
            public static AnchorToken AltStart => new AnchorToken(AnchorConstants._altStartOfString);
            public static AnchorToken End => new AnchorToken(AnchorConstants._endOfString);
            public static AnchorToken AltEnd => new AnchorToken(AnchorConstants._altEndOfString);
            public static AnchorToken AbsoluteEnd => new AnchorToken(AnchorConstants._absoluteEndOfString);
        }
        public static AnchorToken StartOfMatch => new AnchorToken(AnchorConstants._startOfMatch);
        public static AnchorToken WordBoundary => new AnchorToken(AnchorConstants._wordBoundary);
        public static AnchorToken NonWordBoundary => new AnchorToken(AnchorConstants._nonWordBoundary);
    }
}
