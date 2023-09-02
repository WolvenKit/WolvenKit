using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CodexImageButton : CodexListItemController
	{
		[Ordinal(19)] 
		[RED("image")] 
		public inkImageWidgetReference Image
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("border")] 
		public inkImageWidgetReference Border
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("translateOnSelect")] 
		public inkWidgetReference TranslateOnSelect
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("selectTranslationX")] 
		public CFloat SelectTranslationX
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public CodexImageButton()
		{
			Image = new inkImageWidgetReference();
			Border = new inkImageWidgetReference();
			TranslateOnSelect = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
