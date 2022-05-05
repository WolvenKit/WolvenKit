
namespace WolvenKit.RED4.Types
{
	public partial class gamedataSmartGunTargetSortConfigurations_Record
	{
		[RED("adsConfig")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID AdsConfig
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("hipConfig")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID HipConfig
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
