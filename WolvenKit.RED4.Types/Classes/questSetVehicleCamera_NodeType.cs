using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSetVehicleCamera_NodeType : questIVehicleManagerNodeType
	{
		private CEnum<questVehicleCameraType> _cameraType;
		private CBool _blockOtherCameras;

		[Ordinal(0)] 
		[RED("cameraType")] 
		public CEnum<questVehicleCameraType> CameraType
		{
			get => GetProperty(ref _cameraType);
			set => SetProperty(ref _cameraType, value);
		}

		[Ordinal(1)] 
		[RED("blockOtherCameras")] 
		public CBool BlockOtherCameras
		{
			get => GetProperty(ref _blockOtherCameras);
			set => SetProperty(ref _blockOtherCameras, value);
		}
	}
}
