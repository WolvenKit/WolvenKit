using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LanguageCheckbox : ContentCheckbox
	{
		[Ordinal(39)] 
		[RED("identifier")] 
		public CEnum<inkModioLanguageTagsOptions> Identifier
		{
			get => GetPropertyValue<CEnum<inkModioLanguageTagsOptions>>();
			set => SetPropertyValue<CEnum<inkModioLanguageTagsOptions>>(value);
		}

		public LanguageCheckbox()
		{
			CheckboxCanvas = new inkWidgetReference();
			CheckboxImage = new inkImageWidgetReference();
			CheckboxText = new inkTextWidgetReference();
			ColorNames = new ModsMenuColorsNames();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
