using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIActionHelperTask : AIbehaviortaskScript
	{
		[Ordinal(0)]  [RED("actionID")] public TweakDBID ActionID { get; set; }
		[Ordinal(1)]  [RED("actionName")] public CName ActionName { get; set; }
		[Ordinal(2)]  [RED("actionStringName")] public CString ActionStringName { get; set; }
		[Ordinal(3)]  [RED("actionTweakIDMapping")] public CHandle<AIArgumentMapping> ActionTweakIDMapping { get; set; }
		[Ordinal(4)]  [RED("initialized")] public CBool Initialized { get; set; }

		public AIActionHelperTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
