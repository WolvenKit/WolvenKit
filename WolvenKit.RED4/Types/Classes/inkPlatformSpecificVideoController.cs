using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkPlatformSpecificVideoController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("isLooped")] 
		public CBool IsLooped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("video")] 
		public CResourceAsyncReference<Bink> Video
		{
			get => GetPropertyValue<CResourceAsyncReference<Bink>>();
			set => SetPropertyValue<CResourceAsyncReference<Bink>>(value);
		}

		[Ordinal(3)] 
		[RED("video_PS4")] 
		public CResourceAsyncReference<Bink> Video_PS4
		{
			get => GetPropertyValue<CResourceAsyncReference<Bink>>();
			set => SetPropertyValue<CResourceAsyncReference<Bink>>(value);
		}

		[Ordinal(4)] 
		[RED("video_XB1")] 
		public CResourceAsyncReference<Bink> Video_XB1
		{
			get => GetPropertyValue<CResourceAsyncReference<Bink>>();
			set => SetPropertyValue<CResourceAsyncReference<Bink>>(value);
		}

		public inkPlatformSpecificVideoController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
