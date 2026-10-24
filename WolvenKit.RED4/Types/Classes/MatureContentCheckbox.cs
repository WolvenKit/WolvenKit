using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MatureContentCheckbox : ContentCheckbox
	{
		[Ordinal(39)] 
		[RED("bIsBrowserMenu")] 
		public CBool BIsBrowserMenu
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public MatureContentCheckbox()
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
