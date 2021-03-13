using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldCompiledSmartObjectsNode : worldNode
	{
		[Ordinal(4)] [RED("resource")] public raRef<gameSmartObjectsCompiledResource> Resource { get; set; }

		public worldCompiledSmartObjectsNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
