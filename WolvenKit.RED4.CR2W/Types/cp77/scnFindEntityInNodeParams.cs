using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnFindEntityInNodeParams : CVariable
	{
		[Ordinal(0)] [RED("nodeRef")] public NodeRef NodeRef { get; set; }
		[Ordinal(1)] [RED("forceMaxVisibility")] public CBool ForceMaxVisibility { get; set; }

		public scnFindEntityInNodeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
