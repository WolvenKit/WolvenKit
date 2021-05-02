using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetVehicleCamera_NodeType : questIVehicleManagerNodeType
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

		public questSetVehicleCamera_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
