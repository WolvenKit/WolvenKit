
namespace WolvenKit.RED4.Types
{
	public partial class gamedataCoverTypeCoverSelectionParameters_Record
	{
		[RED("coverScore")]
		[REDProperty(IsIgnored = true)]
		public CFloat CoverScore
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxScore")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxScore
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("shootingSpotScore")]
		[REDProperty(IsIgnored = true)]
		public CFloat ShootingSpotScore
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
