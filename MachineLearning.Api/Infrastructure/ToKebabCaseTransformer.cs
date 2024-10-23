using System.Text.RegularExpressions;

namespace Ifs.Api.Infrastructure
{
    public partial class ToKebabCaseTransformer : IOutboundParameterTransformer
    {
        [GeneratedRegex("([a-z])([A-Z])")]
        private static partial Regex KebabRegex();

        public string? TransformOutbound(object? value) => value != null
            ? KebabRegex().Replace(value.ToString()!, "$1-$2").ToLower() // to kebab 
            : null;
    }
}
