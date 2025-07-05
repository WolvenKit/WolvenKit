
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAngleDistanceCoverSelectionParameters_Record
	{
		[RED("angleDistanceScore")]
		[REDProperty(IsIgnored = true)]
		public CFloat AngleDistanceScore
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("closestThreatsAmountToIgnoreDistanceCheck")]
		[REDProperty(IsIgnored = true)]
		public CInt32 ClosestThreatsAmountToIgnoreDistanceCheck
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("coverLowerMinVerticalAngle")]
		[REDProperty(IsIgnored = true)]
		public CFloat CoverLowerMinVerticalAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("coverProtectionAngleMul")]
		[REDProperty(IsIgnored = true)]
		public CFloat CoverProtectionAngleMul
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maximumDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaximumDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minThreatsAmountToCheckDistance")]
		[REDProperty(IsIgnored = true)]
		public CInt32 MinThreatsAmountToCheckDistance
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("shootingSpotLowerMinVerticalAngle")]
		[REDProperty(IsIgnored = true)]
		public CFloat ShootingSpotLowerMinVerticalAngle
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
		
		[RED("verticalAngleCooldown")]
		[REDProperty(IsIgnored = true)]
		public CFloat VerticalAngleCooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
