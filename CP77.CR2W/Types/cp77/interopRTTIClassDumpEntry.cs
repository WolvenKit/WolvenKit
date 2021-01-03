using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class interopRTTIClassDumpEntry : CVariable
	{
		[Ordinal(0)]  [RED("a")] public CInt32 A { get; set; }
		[Ordinal(1)]  [RED("b")] public CInt32 B { get; set; }
		[Ordinal(2)]  [RED("i")] public CInt32 I { get; set; }
		[Ordinal(3)]  [RED("r")] public CInt32 R { get; set; }

		public interopRTTIClassDumpEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
