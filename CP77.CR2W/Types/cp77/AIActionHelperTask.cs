using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIActionHelperTask : AIbehaviortaskScript
	{
		[Ordinal(0)] [RED("actionTweakIDMapping")] public CHandle<AIArgumentMapping> ActionTweakIDMapping { get; set; }
		[Ordinal(1)] [RED("actionStringName")] public CString ActionStringName { get; set; }
		[Ordinal(2)] [RED("initialized")] public CBool Initialized { get; set; }
		[Ordinal(3)] [RED("actionName")] public CName ActionName { get; set; }
		[Ordinal(4)] [RED("actionID")] public TweakDBID ActionID { get; set; }

		public AIActionHelperTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
