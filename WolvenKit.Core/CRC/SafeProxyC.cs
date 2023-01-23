/* This is .NET safe implementation of Crc32C algorithm.
 * See detailed comments in Crc32 implementation
 *
 * Max Vysokikh, 2016-2017
 */

namespace WolvenKit.Core.CRC
{
    internal class SafeProxyC : SafeProxy
    {
        #region Fields

        private const uint Poly = 0x82F63B78u;

        #endregion Fields

        #region Constructors

        internal SafeProxyC() => Init(Poly);

        #endregion Constructors
    }
}
