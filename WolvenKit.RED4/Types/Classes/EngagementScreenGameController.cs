using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EngagementScreenGameController : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("backgroundVideo")] 
		public inkVideoWidgetReference BackgroundVideo
		{
			get => GetPropertyValue<inkVideoWidgetReference>();
			set => SetPropertyValue<inkVideoWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("text")] 
		public inkRichTextBoxWidgetReference Text
		{
			get => GetPropertyValue<inkRichTextBoxWidgetReference>();
			set => SetPropertyValue<inkRichTextBoxWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("textShadow")] 
		public inkRichTextBoxWidgetReference TextShadow
		{
			get => GetPropertyValue<inkRichTextBoxWidgetReference>();
			set => SetPropertyValue<inkRichTextBoxWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("textContainer")] 
		public inkCompoundWidgetReference TextContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		public EngagementScreenGameController()
		{
			BackgroundVideo = new();
			Text = new();
			TextShadow = new();
			TextContainer = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
