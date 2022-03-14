
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleWheelDrivingSetup_4_Record
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
		
		[RED("LB")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID LB
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("LF")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID LF
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("RB")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID RB
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("RF")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID RF
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
