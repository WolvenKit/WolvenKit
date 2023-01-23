using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SimpleBinkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(16)] 
		[RED("playCommonAd")] 
		public CBool PlayCommonAd
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("Video1Path")] 
		public CName Video1Path
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(18)] 
		[RED("Video2Path")] 
		public CName Video2Path
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(19)] 
		[RED("Video1")] 
		public inkVideoWidgetReference Video1
		{
			get => GetPropertyValue<inkVideoWidgetReference>();
			set => SetPropertyValue<inkVideoWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("Video2")] 
		public inkVideoWidgetReference Video2
		{
			get => GetPropertyValue<inkVideoWidgetReference>();
			set => SetPropertyValue<inkVideoWidgetReference>(value);
		}

		public SimpleBinkGameController()
		{
			PlayCommonAd = true;
			Video1Path = "Video1";
			Video2Path = "Video2";
			Video1 = new();
			Video2 = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
