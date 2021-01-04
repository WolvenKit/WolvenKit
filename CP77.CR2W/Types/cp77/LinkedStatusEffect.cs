using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class LinkedStatusEffect : CVariable
	{
		[Ordinal(0)]  [RED("netrunnerIDs")] public CArray<entEntityID> NetrunnerIDs { get; set; }
		[Ordinal(1)]  [RED("statusEffectList")] public CArray<TweakDBID> StatusEffectList { get; set; }
		[Ordinal(2)]  [RED("targetID")] public entEntityID TargetID { get; set; }

		public LinkedStatusEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
