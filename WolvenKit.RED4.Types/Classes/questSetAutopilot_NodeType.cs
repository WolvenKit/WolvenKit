using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSetAutopilot_NodeType : questIVehicleManagerNodeType
	{
		private gameEntityReference _vehicleRef;
		private CBool _val;

		[Ordinal(0)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get => GetProperty(ref _vehicleRef);
			set => SetProperty(ref _vehicleRef, value);
		}

		[Ordinal(1)] 
		[RED("val")] 
		public CBool Val
		{
			get => GetProperty(ref _val);
			set => SetProperty(ref _val, value);
		}

		public questSetAutopilot_NodeType()
		{
			_val = true;
		}
	}
}
