using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldProxyWindowsParams : CVariable
	{
		[Ordinal(0)] [RED("windowsType")] public CEnum<worldProxWindowsType> WindowsType { get; set; }
		[Ordinal(1)] [RED("distance")] public CFloat Distance { get; set; }
		[Ordinal(2)] [RED("distanceAboveProxy")] public CFloat DistanceAboveProxy { get; set; }
		[Ordinal(3)] [RED("boolean")] public CBool Boolean { get; set; }
		[Ordinal(4)] [RED("removeSmallerThan")] public CFloat RemoveSmallerThan { get; set; }
		[Ordinal(5)] [RED("distantWindowsEmissive")] public CFloat DistantWindowsEmissive { get; set; }
		[Ordinal(6)] [RED("distantWindowsSize")] public CFloat DistantWindowsSize { get; set; }
		[Ordinal(7)] [RED("distantWindowsSaturation")] public CFloat DistantWindowsSaturation { get; set; }
		[Ordinal(8)] [RED("distantWindowsTurnedOf")] public CFloat DistantWindowsTurnedOf { get; set; }

		public worldProxyWindowsParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
