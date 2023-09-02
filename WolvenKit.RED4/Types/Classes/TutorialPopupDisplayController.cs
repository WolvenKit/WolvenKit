using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TutorialPopupDisplayController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("title")] 
		public inkTextWidgetReference Title
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("message")] 
		public inkTextWidgetReference Message
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("image")] 
		public inkImageWidgetReference Image
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("video_1360x768")] 
		public inkVideoWidgetReference Video_1360x768
		{
			get => GetPropertyValue<inkVideoWidgetReference>();
			set => SetPropertyValue<inkVideoWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("video_1024x576")] 
		public inkVideoWidgetReference Video_1024x576
		{
			get => GetPropertyValue<inkVideoWidgetReference>();
			set => SetPropertyValue<inkVideoWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("video_1280x720")] 
		public inkVideoWidgetReference Video_1280x720
		{
			get => GetPropertyValue<inkVideoWidgetReference>();
			set => SetPropertyValue<inkVideoWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("video_720x405")] 
		public inkVideoWidgetReference Video_720x405
		{
			get => GetPropertyValue<inkVideoWidgetReference>();
			set => SetPropertyValue<inkVideoWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("inputHint")] 
		public inkWidgetReference InputHint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public TutorialPopupDisplayController()
		{
			Title = new inkTextWidgetReference();
			Message = new inkTextWidgetReference();
			Image = new inkImageWidgetReference();
			Video_1360x768 = new inkVideoWidgetReference();
			Video_1024x576 = new inkVideoWidgetReference();
			Video_1280x720 = new inkVideoWidgetReference();
			Video_720x405 = new inkVideoWidgetReference();
			InputHint = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
