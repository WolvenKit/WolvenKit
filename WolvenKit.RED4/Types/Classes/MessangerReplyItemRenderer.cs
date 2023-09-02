using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MessangerReplyItemRenderer : JournalEntryListItemController
	{
		[Ordinal(16)] 
		[RED("textRoot")] 
		public inkWidgetReference TextRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("background")] 
		public inkWidgetReference Background
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("animSelectionBackground")] 
		public CHandle<inkanimProxy> AnimSelectionBackground
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(19)] 
		[RED("animSelectionText")] 
		public CHandle<inkanimProxy> AnimSelectionText
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(20)] 
		[RED("selectedState")] 
		public CBool SelectedState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("animationDuration")] 
		public CFloat AnimationDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public MessangerReplyItemRenderer()
		{
			TextRoot = new inkWidgetReference();
			Background = new inkWidgetReference();
			AnimationDuration = 0.300000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
