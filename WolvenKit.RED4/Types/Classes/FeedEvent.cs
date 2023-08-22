using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FeedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("On")] 
		public CBool On
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("virtualComponentName")] 
		public CName VirtualComponentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("cameraID")] 
		public entEntityID CameraID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public FeedEvent()
		{
			CameraID = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
