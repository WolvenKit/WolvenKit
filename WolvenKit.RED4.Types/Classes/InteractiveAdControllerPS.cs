using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InteractiveAdControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
		[RED("showAd")] 
		public CBool ShowAd
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(105)] 
		[RED("showVendor")] 
		public CBool ShowVendor
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(106)] 
		[RED("locationAdded")] 
		public CBool LocationAdded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public InteractiveAdControllerPS()
		{
			DeviceName = "LocKey#197";
			TweakDBRecord = 92183574454;
			TweakDBDescriptionRecord = 143211166331;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
