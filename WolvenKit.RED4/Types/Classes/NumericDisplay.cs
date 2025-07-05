
namespace WolvenKit.RED4.Types
{
	public partial class NumericDisplay : InteractiveDevice
	{
		public NumericDisplay()
		{
			ControllerTypeName = "NumericDisplayController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
