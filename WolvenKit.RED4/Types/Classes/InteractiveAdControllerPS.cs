using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InteractiveAdControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("showAd")] 
		public CBool ShowAd
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(108)] 
		[RED("showVendor")] 
		public CBool ShowVendor
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(109)] 
		[RED("locationAdded")] 
		public CBool LocationAdded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public InteractiveAdControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
