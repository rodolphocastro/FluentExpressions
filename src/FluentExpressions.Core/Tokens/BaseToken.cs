using System;

namespace FluentExpressions.Core.Tokens
{
    /// <summary>
    /// Token para construção de Regex.
    /// </summary>
    public abstract class BaseToken : IEquatable<BaseToken>
    {
        protected readonly string _value;

        protected BaseToken(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Um valor deve ser definido", nameof(value));
            }

            _value = value;
        }

        public string Value => _value;

        public bool Equals(BaseToken other) => other.Value.Equals(_value);
        public override string ToString() => _value;

        public static implicit operator string(BaseToken token) => token.Value;
    }
}
