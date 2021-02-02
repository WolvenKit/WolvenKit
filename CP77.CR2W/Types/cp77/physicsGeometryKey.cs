using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class physicsGeometryKey : CVariable
	{
		[Ordinal(0)]  [RED("ta", 12)] public CArrayFixedSize<CUInt8> Ta { get; set; }
		[Ordinal(1)]  [RED("pe")] public CUInt8 Pe { get; set; }

		public physicsGeometryKey(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
