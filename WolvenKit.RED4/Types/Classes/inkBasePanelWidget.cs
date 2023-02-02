
namespace WolvenKit.RED4.Types
{
	public partial class inkBasePanelWidget : inkCompoundWidget
	{
		public inkBasePanelWidget()
		{
			FitToContent = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
