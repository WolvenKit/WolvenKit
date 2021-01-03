using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorBehaviorIncludedDebuggerCommandEntry : CVariable
	{
		[Ordinal(0)]  [RED("includedBehaviorResourcePath")] public CString IncludedBehaviorResourcePath { get; set; }
		[Ordinal(1)]  [RED("nodeId")] public CGUID NodeId { get; set; }

		public AIbehaviorBehaviorIncludedDebuggerCommandEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
