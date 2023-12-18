using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CoolExitingEvents : ExitingEvents
	{
		[Ordinal(5)] 
		[RED("exitMomentum")] 
		public Vector4 ExitMomentum
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(6)] 
		[RED("coolExitMagnitude")] 
		public CEnum<vehicleCoolExitImpulseLevel> CoolExitMagnitude
		{
			get => GetPropertyValue<CEnum<vehicleCoolExitImpulseLevel>>();
			set => SetPropertyValue<CEnum<vehicleCoolExitImpulseLevel>>(value);
		}

		[Ordinal(7)] 
		[RED("willEquipMeleeWeapon")] 
		public CBool WillEquipMeleeWeapon
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("cwArmsEquipRequested")] 
		public CBool CwArmsEquipRequested
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("cwArmsEquipCompleted")] 
		public CBool CwArmsEquipCompleted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("vehicleInTPP")] 
		public CBool VehicleInTPP
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("vehicleInTPPCallback")] 
		public CHandle<redCallbackObject> VehicleInTPPCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public CoolExitingEvents()
		{
			ExitSlot = "cool";
			ExitMomentum = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
