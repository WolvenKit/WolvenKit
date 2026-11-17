
namespace WolvenKit.RED4.Types
{
	public partial class worldVehicleForbiddenAreaNode : worldTriggerAreaNode
	{
		public worldVehicleForbiddenAreaNode()
		{
			Color = new CColor { Red = 32, Green = 32, Blue = 32, Alpha = 128 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
