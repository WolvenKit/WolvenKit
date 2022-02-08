using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questUnassignAll_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("isInstant")] 
		public CBool IsInstant
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questUnassignAll_NodeType()
		{
			VehicleRef = new() { Names = new() };
		}
	}
}
