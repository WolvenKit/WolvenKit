using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WeaponVendingMachine : VendingMachine
	{
		[Ordinal(98)] 
		[RED("bigAdScreen")] 
		public CWeakHandle<IWorldWidgetComponent> BigAdScreen
		{
			get => GetPropertyValue<CWeakHandle<IWorldWidgetComponent>>();
			set => SetPropertyValue<CWeakHandle<IWorldWidgetComponent>>(value);
		}

		public WeaponVendingMachine()
		{
			ControllerTypeName = "WeaponVendingMachineController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
