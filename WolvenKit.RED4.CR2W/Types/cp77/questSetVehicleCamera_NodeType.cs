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
			get
			{
				if (_cameraType == null)
				{
					_cameraType = (CEnum<questVehicleCameraType>) CR2WTypeManager.Create("questVehicleCameraType", "cameraType", cr2w, this);
				}
				return _cameraType;
			}
			set
			{
				if (_cameraType == value)
				{
					return;
				}
				_cameraType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("blockOtherCameras")] 
		public CBool BlockOtherCameras
		{
			get
			{
				if (_blockOtherCameras == null)
				{
					_blockOtherCameras = (CBool) CR2WTypeManager.Create("Bool", "blockOtherCameras", cr2w, this);
				}
				return _blockOtherCameras;
			}
			set
			{
				if (_blockOtherCameras == value)
				{
					return;
				}
				_blockOtherCameras = value;
				PropertySet(this);
			}
		}

		public questSetVehicleCamera_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
