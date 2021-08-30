using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questToggleBrokenTire_NodeType : questIVehicleManagerNodeType
	{
		private gameEntityReference _vehicleRef;
		private CBool _val;
		private CUInt32 _tire;

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

		[Ordinal(2)] 
		[RED("tire")] 
		public CUInt32 Tire
		{
			get => GetProperty(ref _tire);
			set => SetProperty(ref _tire, value);
		}

		public questToggleBrokenTire_NodeType()
		{
			_val = true;
		}
	}
}
