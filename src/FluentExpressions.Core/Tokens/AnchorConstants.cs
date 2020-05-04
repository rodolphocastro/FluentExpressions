using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Tests.Core")]
namespace FluentExpressions.Core.Tokens
{
    /// <summary>
    /// Constantes de Anchors.
    /// </summary>
    internal static class AnchorConstants
    {
        /// <summary>
        /// Start of a Match (\G).
        /// </summary>
        public const string _startOfMatch = @"\G";

        /// <summary>
        /// Start of a String (^).
        /// </summary>
        public const string _startOfString = @"^";

        /// <summary>
        /// Alternative Start of a String (\A).
        /// </summary>
        public const string _altStartOfString = @"\A";

        /// <summary>
        /// End of a String ($).
        /// </summary>
        public const string _endOfString = @"$";

        /// <summary>
        /// Alternative End of a String (\Z).
        /// </summary>
        public const string _altEndOfString = @"\Z";

        /// <summary>
        /// Absolute End of a String (\z).
        /// </summary>
        public const string _absoluteEndOfString = @"\z";

        /// <summary>
        /// Word boundary (\b).
        /// </summary>
        public const string _wordBoundary = @"\b";

        /// <summary>
        /// Non-Word boundary (\B).
        /// </summary>
        public const string _nonWordBoundary = @"\B";
    }
}
