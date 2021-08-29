using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FilterNPCDodgeOpportunity : gameEffectObjectGroupFilter_Scripted
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
	}
}
