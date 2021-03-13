using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetFOV_NodeType : questISceneManagerNodeType
	{
		[Ordinal(0)] [RED("FOV")] public CFloat FOV { get; set; }

		public questSetFOV_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
