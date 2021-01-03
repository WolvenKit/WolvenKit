using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questSetFOV_NodeType : questISceneManagerNodeType
	{
		[Ordinal(0)]  [RED("FOV")] public CFloat FOV { get; set; }

		public questSetFOV_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
