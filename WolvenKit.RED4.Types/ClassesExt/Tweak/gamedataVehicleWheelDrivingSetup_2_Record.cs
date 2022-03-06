
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleWheelDrivingSetup_2_Record
	{
		[RED("B")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID B
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("backPreset")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID BackPreset
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("F")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID F
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
