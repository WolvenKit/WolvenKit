
namespace WolvenKit.RED4.Types
{
	public partial class gamedataThreatDistanceCoverSelectionParameters_Record
	{
		[RED("allowNegativeThreatMaxDistanceScoring")]
		[REDProperty(IsIgnored = true)]
		public CBool AllowNegativeThreatMaxDistanceScoring
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("checkThreatDestination")]
		[REDProperty(IsIgnored = true)]
		public CBool CheckThreatDestination
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("checkThreatPath")]
		[REDProperty(IsIgnored = true)]
		public CBool CheckThreatPath
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("distanceToThreatMultiplier")]
		[REDProperty(IsIgnored = true)]
		public CFloat DistanceToThreatMultiplier
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
		
		[RED("threatMaxDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat ThreatMaxDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("threatMinDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat ThreatMinDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("threatPredictionTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat ThreatPredictionTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("threatPreferredDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat ThreatPreferredDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("useThreatMaxDistanceFiltering")]
		[REDProperty(IsIgnored = true)]
		public CBool UseThreatMaxDistanceFiltering
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
