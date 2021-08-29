using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkPlatformSpecificVideoController : inkWidgetLogicController
	{
		private CBool _isLooped;
		private CResourceAsyncReference<Bink> _video;
		private CResourceAsyncReference<Bink> _video_PS4;
		private CResourceAsyncReference<Bink> _video_XB1;

		[Ordinal(1)] 
		[RED("isLooped")] 
		public CBool IsLooped
		{
			get => GetProperty(ref _isLooped);
			set => SetProperty(ref _isLooped, value);
		}

		[Ordinal(2)] 
		[RED("video")] 
		public CResourceAsyncReference<Bink> Video
		{
			get => GetProperty(ref _video);
			set => SetProperty(ref _video, value);
		}

		[Ordinal(3)] 
		[RED("video_PS4")] 
		public CResourceAsyncReference<Bink> Video_PS4
		{
			get => GetProperty(ref _video_PS4);
			set => SetProperty(ref _video_PS4, value);
		}

		[Ordinal(4)] 
		[RED("video_XB1")] 
		public CResourceAsyncReference<Bink> Video_XB1
		{
			get => GetProperty(ref _video_XB1);
			set => SetProperty(ref _video_XB1, value);
		}
	}
}
