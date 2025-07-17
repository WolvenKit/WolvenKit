
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleVisualCustomizationPreviewGlowSetup_Record
	{
		[RED("backgroundImage")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID BackgroundImage
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[RED("lightsImage")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID LightsImage
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[RED("primaryImage")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID PrimaryImage
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[RED("secondaryImage")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID SecondaryImage
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
