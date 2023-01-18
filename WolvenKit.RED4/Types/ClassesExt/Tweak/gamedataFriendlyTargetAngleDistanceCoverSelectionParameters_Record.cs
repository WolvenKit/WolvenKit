
namespace WolvenKit.RED4.Types
{
	public partial class gamedataFriendlyTargetAngleDistanceCoverSelectionParameters_Record
	{
		[RED("angleDistanceScore")]
		[REDProperty(IsIgnored = true)]
		public CFloat AngleDistanceScore
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
		
		[RED("maxScoreIfInRange")]
		[REDProperty(IsIgnored = true)]
		public CBool MaxScoreIfInRange
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("minDot")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinDot
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("positionChangeThreshold")]
		[REDProperty(IsIgnored = true)]
		public CFloat PositionChangeThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
