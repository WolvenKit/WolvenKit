
namespace WolvenKit.RED4.Types
{
	public partial class gamedataUtilityLossCoverSelectionParameters_Record
	{
		[RED("hitsTakenToClearScoreCover")]
		[REDProperty(IsIgnored = true)]
		public CInt32 HitsTakenToClearScoreCover
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("hitsTakenToClearScoreInIdle")]
		[REDProperty(IsIgnored = true)]
		public CInt32 HitsTakenToClearScoreInIdle
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("hitsTakenToClearScoreShootingSpot")]
		[REDProperty(IsIgnored = true)]
		public CInt32 HitsTakenToClearScoreShootingSpot
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("utilityLossMultiplier")]
		[REDProperty(IsIgnored = true)]
		public CFloat UtilityLossMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("utilityLossTimeoutCover")]
		[REDProperty(IsIgnored = true)]
		public CFloat UtilityLossTimeoutCover
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("utilityLossTimeoutInIdle")]
		[REDProperty(IsIgnored = true)]
		public CFloat UtilityLossTimeoutInIdle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("utilityLossTimeoutShootingSpot")]
		[REDProperty(IsIgnored = true)]
		public CFloat UtilityLossTimeoutShootingSpot
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
