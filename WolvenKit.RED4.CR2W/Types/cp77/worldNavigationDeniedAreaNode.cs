using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldNavigationDeniedAreaNode : worldAreaShapeNode
	{
		[Ordinal(6)] [RED("flags")] public CEnum<worldEDeniedAreaFlags> Flags { get; set; }

		public worldNavigationDeniedAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
