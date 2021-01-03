using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SHitFlag : CVariable
	{
		[Ordinal(0)]  [RED("flag")] public CEnum<hitFlag> Flag { get; set; }
		[Ordinal(1)]  [RED("source")] public CName Source { get; set; }

		public SHitFlag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
