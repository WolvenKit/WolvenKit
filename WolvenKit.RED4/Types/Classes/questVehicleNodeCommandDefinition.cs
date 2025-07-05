using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questVehicleNodeCommandDefinition : questAICommandNodeBase
	{
		[Ordinal(2)] 
		[RED("vehicle")] 
		public gameEntityReference Vehicle
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(3)] 
		[RED("commandParams")] 
		public CHandle<questVehicleCommandParams> CommandParams
		{
			get => GetPropertyValue<CHandle<questVehicleCommandParams>>();
			set => SetPropertyValue<CHandle<questVehicleCommandParams>>(value);
		}

		public questVehicleNodeCommandDefinition()
		{
			Sockets = new();
			Id = ushort.MaxValue;
			Vehicle = new gameEntityReference { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
