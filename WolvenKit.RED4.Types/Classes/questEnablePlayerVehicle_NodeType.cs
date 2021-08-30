using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questEnablePlayerVehicle_NodeType : questIVehicleManagerNodeType
	{
		private CString _vehicle;
		private CBool _enable;
		private CBool _despawn;
		private CBool _makePlayerActiveVehicle;

		[Ordinal(0)] 
		[RED("vehicle")] 
		public CString Vehicle
		{
			get => GetProperty(ref _vehicle);
			set => SetProperty(ref _vehicle, value);
		}

		[Ordinal(1)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetProperty(ref _enable);
			set => SetProperty(ref _enable, value);
		}

		[Ordinal(2)] 
		[RED("despawn")] 
		public CBool Despawn
		{
			get => GetProperty(ref _despawn);
			set => SetProperty(ref _despawn, value);
		}

		[Ordinal(3)] 
		[RED("makePlayerActiveVehicle")] 
		public CBool MakePlayerActiveVehicle
		{
			get => GetProperty(ref _makePlayerActiveVehicle);
			set => SetProperty(ref _makePlayerActiveVehicle, value);
		}

		public questEnablePlayerVehicle_NodeType()
		{
			_enable = true;
			_despawn = true;
			_makePlayerActiveVehicle = true;
		}
	}
}
