using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class physicsGeometryKey : CVariable
	{
		[Ordinal(0)]  [RED("pe")] public CUInt8 Pe { get; set; }
		[Ordinal(1)]  [RED("ta")] public [12]Uint8 Ta { get; set; }

		public physicsGeometryKey(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
