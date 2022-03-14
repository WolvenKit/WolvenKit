
namespace WolvenKit.RED4.Types
{
	public partial class gamedataOwnerDistanceCoverSelectionParameters_Record
	{
		[RED("distanceToOwnerMultiplier")]
		[REDProperty(IsIgnored = true)]
		public CFloat DistanceToOwnerMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("ownerMaxDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat OwnerMaxDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("ownerMinDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat OwnerMinDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("ownerPreferredDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat OwnerPreferredDistance
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
