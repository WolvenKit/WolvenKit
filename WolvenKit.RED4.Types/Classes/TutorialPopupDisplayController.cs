using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TutorialPopupDisplayController : inkWidgetLogicController
	{
		private inkTextWidgetReference _title;
		private inkTextWidgetReference _message;
		private inkImageWidgetReference _image;
		private inkVideoWidgetReference _video_1360x768;
		private inkVideoWidgetReference _video_1024x576;
		private inkVideoWidgetReference _video_1280x720;
		private inkVideoWidgetReference _video_720x405;
		private inkWidgetReference _inputHint;

		[Ordinal(1)] 
		[RED("title")] 
		public inkTextWidgetReference Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(2)] 
		[RED("message")] 
		public inkTextWidgetReference Message
		{
			get => GetProperty(ref _message);
			set => SetProperty(ref _message, value);
		}

		[Ordinal(3)] 
		[RED("image")] 
		public inkImageWidgetReference Image
		{
			get => GetProperty(ref _image);
			set => SetProperty(ref _image, value);
		}

		[Ordinal(4)] 
		[RED("video_1360x768")] 
		public inkVideoWidgetReference Video_1360x768
		{
			get => GetProperty(ref _video_1360x768);
			set => SetProperty(ref _video_1360x768, value);
		}

		[Ordinal(5)] 
		[RED("video_1024x576")] 
		public inkVideoWidgetReference Video_1024x576
		{
			get => GetProperty(ref _video_1024x576);
			set => SetProperty(ref _video_1024x576, value);
		}

		[Ordinal(6)] 
		[RED("video_1280x720")] 
		public inkVideoWidgetReference Video_1280x720
		{
			get => GetProperty(ref _video_1280x720);
			set => SetProperty(ref _video_1280x720, value);
		}

		[Ordinal(7)] 
		[RED("video_720x405")] 
		public inkVideoWidgetReference Video_720x405
		{
			get => GetProperty(ref _video_720x405);
			set => SetProperty(ref _video_720x405, value);
		}

		[Ordinal(8)] 
		[RED("inputHint")] 
		public inkWidgetReference InputHint
		{
			get => GetProperty(ref _inputHint);
			set => SetProperty(ref _inputHint, value);
		}
	}
}
