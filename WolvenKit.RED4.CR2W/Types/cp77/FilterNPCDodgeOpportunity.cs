using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FilterNPCDodgeOpportunity : gameEffectObjectSingleFilter_Scripted
	{
		private CBool _applyToTechWeapons;
		private CBool _doDodgingTargetsGetFilteredOut;

		[Ordinal(0)] 
		[RED("applyToTechWeapons")] 
		public CBool ApplyToTechWeapons
		{
			get => GetProperty(ref _applyToTechWeapons);
			set => SetProperty(ref _applyToTechWeapons, value);
		}

		[Ordinal(1)] 
		[RED("doDodgingTargetsGetFilteredOut")] 
		public CBool DoDodgingTargetsGetFilteredOut
		{
			get => GetProperty(ref _doDodgingTargetsGetFilteredOut);
			set => SetProperty(ref _doDodgingTargetsGetFilteredOut, value);
		}

		public FilterNPCDodgeOpportunity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
