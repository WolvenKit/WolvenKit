
namespace WolvenKit.RED4.Types
{
	public partial class gamedataKeepCurrentCoverCoverSelectionParameters_Record
	{
		[RED("keepCoverBonus")]
		[REDProperty(IsIgnored = true)]
		public CFloat KeepCoverBonus
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("scoreOnlyForCombatTarget")]
		[REDProperty(IsIgnored = true)]
		public CBool ScoreOnlyForCombatTarget
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("vaidateOnlyForCombatTarget")]
		[REDProperty(IsIgnored = true)]
		public CBool VaidateOnlyForCombatTarget
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
