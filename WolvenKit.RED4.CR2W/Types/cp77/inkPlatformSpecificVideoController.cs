using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkPlatformSpecificVideoController : inkWidgetLogicController
	{
		private CBool _isLooped;
		private raRef<Bink> _video;
		private raRef<Bink> _video_PS4;
		private raRef<Bink> _video_XB1;

		[Ordinal(1)] 
		[RED("isLooped")] 
		public CBool IsLooped
		{
			get => GetProperty(ref _isLooped);
			set => SetProperty(ref _isLooped, value);
		}

		[Ordinal(2)] 
		[RED("video")] 
		public raRef<Bink> Video
		{
			get => GetProperty(ref _video);
			set => SetProperty(ref _video, value);
		}

		[Ordinal(3)] 
		[RED("video_PS4")] 
		public raRef<Bink> Video_PS4
		{
			get => GetProperty(ref _video_PS4);
			set => SetProperty(ref _video_PS4, value);
		}

		[Ordinal(4)] 
		[RED("video_XB1")] 
		public raRef<Bink> Video_XB1
		{
			get => GetProperty(ref _video_XB1);
			set => SetProperty(ref _video_XB1, value);
		}

		public inkPlatformSpecificVideoController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
