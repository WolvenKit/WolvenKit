using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FilterNPCDodgeOpportunity : gameEffectObjectSingleFilter_Scripted
	{
		[Ordinal(0)] [RED("applyToTechWeapons")] public CBool ApplyToTechWeapons { get; set; }
		[Ordinal(1)] [RED("doDodgingTargetsGetFilteredOut")] public CBool DoDodgingTargetsGetFilteredOut { get; set; }

		public FilterNPCDodgeOpportunity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
