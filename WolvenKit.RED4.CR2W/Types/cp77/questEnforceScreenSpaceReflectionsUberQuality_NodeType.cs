using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questEnforceScreenSpaceReflectionsUberQuality_NodeType : questIRenderFxManagerNodeType
	{
		[Ordinal(0)] [RED("enabled")] public CBool Enabled { get; set; }

		public questEnforceScreenSpaceReflectionsUberQuality_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
