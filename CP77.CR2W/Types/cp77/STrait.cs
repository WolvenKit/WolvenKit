using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class STrait : CVariable
	{
		[Ordinal(0)] [RED("type")] public CEnum<gamedataTraitType> Type { get; set; }
		[Ordinal(1)] [RED("unlocked")] public CBool Unlocked { get; set; }
		[Ordinal(2)] [RED("currLevel")] public CInt32 CurrLevel { get; set; }

		public STrait(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
