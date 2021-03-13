using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LinkedStatusEffect : CVariable
	{
		[Ordinal(0)] [RED("netrunnerIDs")] public CArray<entEntityID> NetrunnerIDs { get; set; }
		[Ordinal(1)] [RED("targetID")] public entEntityID TargetID { get; set; }
		[Ordinal(2)] [RED("statusEffectList")] public CArray<TweakDBID> StatusEffectList { get; set; }

		public LinkedStatusEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
