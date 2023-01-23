
namespace WolvenKit.RED4.Types
{
	public partial class inkTextInputWidget : inkTextWidget
	{
		public inkTextInputWidget()
		{
			IsInteractive = true;
			CanSupportFocus = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
