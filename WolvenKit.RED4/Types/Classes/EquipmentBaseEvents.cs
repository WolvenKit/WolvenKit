
namespace WolvenKit.RED4.Types
{
	public abstract partial class EquipmentBaseEvents : EquipmentBaseTransition
	{
		public EquipmentBaseEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
