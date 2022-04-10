using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkTextMotherTongueController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("preTranslatedTextWidget")] 
		public inkTextWidgetReference PreTranslatedTextWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("postTranslatedTextWidget")] 
		public inkTextWidgetReference PostTranslatedTextWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("nativeTextWidget")] 
		public inkRichTextBoxWidgetReference NativeTextWidget
		{
			get => GetPropertyValue<inkRichTextBoxWidgetReference>();
			set => SetPropertyValue<inkRichTextBoxWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("translatedTextWidget")] 
		public inkTextWidgetReference TranslatedTextWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public inkTextMotherTongueController()
		{
			PreTranslatedTextWidget = new();
			PostTranslatedTextWidget = new();
			NativeTextWidget = new();
			TranslatedTextWidget = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
