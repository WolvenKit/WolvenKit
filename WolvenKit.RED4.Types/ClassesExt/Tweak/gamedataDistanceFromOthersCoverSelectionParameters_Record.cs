
namespace WolvenKit.RED4.Types
{
	public partial class gamedataDistanceFromOthersCoverSelectionParameters_Record
	{
		[RED("distanceScoreMultiplier")]
		[REDProperty(IsIgnored = true)]
		public CFloat DistanceScoreMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minimalDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinimalDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minimalPreferredDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinimalPreferredDistance
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
