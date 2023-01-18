
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleWheelDrivingSetup_Record
	{
		[RED("backPreset")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID BackPreset
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("frontPreset")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID FrontPreset
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
