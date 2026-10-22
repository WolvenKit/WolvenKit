using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TagWidgetItem : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("selfRef")] 
		public inkWidgetReference SelfRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("tagText")] 
		public inkRichTextBoxWidgetReference TagText
		{
			get => GetPropertyValue<inkRichTextBoxWidgetReference>();
			set => SetPropertyValue<inkRichTextBoxWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("tagVerticalPanelRef")] 
		public inkWidgetReference TagVerticalPanelRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public TagWidgetItem()
		{
			SelfRef = new inkWidgetReference();
			TagText = new inkRichTextBoxWidgetReference();
			TagVerticalPanelRef = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
