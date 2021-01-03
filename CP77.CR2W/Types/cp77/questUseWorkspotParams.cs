using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questUseWorkspotParams : CVariable
	{
		[Ordinal(0)]  [RED("forceEntryAnimName")] public CName ForceEntryAnimName { get; set; }
		[Ordinal(1)]  [RED("workspotNode")] public NodeRef WorkspotNode { get; set; }

		public questUseWorkspotParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
