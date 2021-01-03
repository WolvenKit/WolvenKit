using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questSetVehicleCamera_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)]  [RED("blockOtherCameras")] public CBool BlockOtherCameras { get; set; }
		[Ordinal(1)]  [RED("cameraType")] public CEnum<questVehicleCameraType> CameraType { get; set; }

		public questSetVehicleCamera_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
