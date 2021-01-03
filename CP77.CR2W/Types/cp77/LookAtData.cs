using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class LookAtData : CVariable
	{
		[Ordinal(0)]  [RED("category")] public CInt32 Category { get; set; }
		[Ordinal(1)]  [RED("idle")] public CInt32 Idle { get; set; }
		[Ordinal(2)]  [RED("personality")] public CEnum<gamedataStatType> Personality { get; set; }

		public LookAtData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
