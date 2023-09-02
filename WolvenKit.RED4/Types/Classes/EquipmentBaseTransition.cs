
namespace WolvenKit.RED4.Types
{
	public abstract partial class EquipmentBaseTransition : DefaultTransition
	{
		public EquipmentBaseTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
