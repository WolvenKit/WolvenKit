using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questVehicleNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIVehicleManagerNodeType> Type
		{
			get => GetPropertyValue<CHandle<questIVehicleManagerNodeType>>();
			set => SetPropertyValue<CHandle<questIVehicleManagerNodeType>>(value);
		}

		public questVehicleNodeDefinition()
		{
			Sockets = new();
			Id = ushort.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
