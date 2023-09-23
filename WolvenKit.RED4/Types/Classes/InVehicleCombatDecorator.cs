using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InVehicleCombatDecorator : AIVehicleTaskAbstract
	{
		[Ordinal(0)] 
		[RED("targetToChase")] 
		public CWeakHandle<gameObject> TargetToChase
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("vehCommand")] 
		public CHandle<AIVehicleChaseCommand> VehCommand
		{
			get => GetPropertyValue<CHandle<AIVehicleChaseCommand>>();
			set => SetPropertyValue<CHandle<AIVehicleChaseCommand>>(value);
		}

		public InVehicleCombatDecorator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
