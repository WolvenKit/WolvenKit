using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questCameraClippingPlane_NodeType : questISceneManagerNodeType
	{
		[Ordinal(0)]  [RED("preset")] public CEnum<questCameraPlanesPreset> Preset { get; set; }

		public questCameraClippingPlane_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
