using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TestBehaviorDelegateTask : AIbehaviortaskScript
	{
		[Ordinal(0)]  [RED("attrRef")] public AIbehaviorDelegateAttrRef AttrRef { get; set; }
		[Ordinal(1)]  [RED("taskRef")] public AIbehaviorDelegateTaskRef TaskRef { get; set; }

		public TestBehaviorDelegateTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
