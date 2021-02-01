using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnFindEntityInNodeParams : CVariable
	{
		[Ordinal(0)]  [RED("forceMaxVisibility")] public CBool ForceMaxVisibility { get; set; }
		[Ordinal(1)]  [RED("nodeRef")] public NodeRef NodeRef { get; set; }

		public scnFindEntityInNodeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
