
namespace WolvenKit.RED4.Types
{
	public partial class LikedFilterCheckbox : ContentCheckbox
	{
		public LikedFilterCheckbox()
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
