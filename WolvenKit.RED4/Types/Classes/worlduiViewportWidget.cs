
namespace WolvenKit.RED4.Types
{
	public partial class worlduiViewportWidget : inkCanvasWidget
	{
		public worlduiViewportWidget()
		{
			IsInteractive = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
