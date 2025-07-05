using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questVehicleWater_ConditionType : questIVehicleConditionType
	{
		[Ordinal(0)] 
		[RED("anyVehicle")] 
		public CBool AnyVehicle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(2)] 
		[RED("submergedOnly")] 
		public CBool SubmergedOnly
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("onEnter")] 
		public CBool OnEnter
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questVehicleWater_ConditionType()
		{
			AnyVehicle = true;
			VehicleRef = new gameEntityReference { Names = new() };
			SubmergedOnly = true;
			OnEnter = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
