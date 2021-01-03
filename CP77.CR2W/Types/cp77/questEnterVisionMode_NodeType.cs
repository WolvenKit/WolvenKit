using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questEnterVisionMode_NodeType : questIVisionModeNodeType
	{
		[Ordinal(0)]  [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
		[Ordinal(1)]  [RED("visionModeType")] public CEnum<gameVisionModeType> VisionModeType { get; set; }

		public questEnterVisionMode_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
