using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using WolvenKit.Common.DDS;
using WolvenKit.RED4.Types;

namespace WolvenKit.Common.Extensions
{
    // https://stackoverflow.com/a/3102439
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> MatchesWildcard<T>(this IEnumerable<T> sequence, Func<T, string> expression, string pattern)
        {
            var regEx = WildcardToRegex(pattern);

            return sequence.Where(item => Regex.IsMatch(expression(item), regEx));
        }

        public static string WildcardToRegex(string pattern) =>
            "^" + Regex.Escape(pattern).
                Replace("\\*", ".*").
                Replace("\\?", ".") + "$";

        public static DXGI_FORMAT ToDirectXTexFormat(this Enums.ETextureRawFormat textureRawFormat, bool isGamma = false) =>
            textureRawFormat switch
            {
                Enums.ETextureRawFormat.TRF_Invalid => DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM,
                Enums.ETextureRawFormat.TRF_TrueColor => isGamma
                    ? DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM_SRGB
                    : DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM,
                Enums.ETextureRawFormat.TRF_DeepColor => DXGI_FORMAT.DXGI_FORMAT_R16G16B16A16_UNORM,
                Enums.ETextureRawFormat.TRF_Grayscale => DXGI_FORMAT.DXGI_FORMAT_R8_UNORM,
                Enums.ETextureRawFormat.TRF_HDRFloat => DXGI_FORMAT.DXGI_FORMAT_R32G32B32A32_FLOAT,
                Enums.ETextureRawFormat.TRF_HDRHalf => DXGI_FORMAT.DXGI_FORMAT_R16G16B16A16_FLOAT,
                Enums.ETextureRawFormat.TRF_HDRFloatGrayscale => DXGI_FORMAT.DXGI_FORMAT_R32_FLOAT,
                Enums.ETextureRawFormat.TRF_R8G8 => DXGI_FORMAT.DXGI_FORMAT_R8G8_UNORM,
                Enums.ETextureRawFormat.TRF_Grayscale_Font => DXGI_FORMAT.DXGI_FORMAT_A8_UNORM,
                _ => throw new ArgumentOutOfRangeException(nameof(textureRawFormat), textureRawFormat, null)
            };
    }
}
