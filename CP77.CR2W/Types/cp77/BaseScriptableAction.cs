using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BaseScriptableAction : gamedeviceAction
	{
		[Ordinal(3)] [RED("requesterID")] public entEntityID RequesterID { get; set; }
		[Ordinal(4)] [RED("executor")] public wCHandle<gameObject> Executor { get; set; }
		[Ordinal(5)] [RED("objectActionID")] public TweakDBID ObjectActionID { get; set; }
		[Ordinal(6)] [RED("objectActionRecord")] public wCHandle<gamedataObjectAction_Record> ObjectActionRecord { get; set; }
		[Ordinal(7)] [RED("inkWidgetID")] public TweakDBID InkWidgetID { get; set; }
		[Ordinal(8)] [RED("interactionChoice")] public gameinteractionsChoice InteractionChoice { get; set; }
		[Ordinal(9)] [RED("interactionLayer")] public CName InteractionLayer { get; set; }
		[Ordinal(10)] [RED("isActionRPGCheckDissabled")] public CBool IsActionRPGCheckDissabled { get; set; }

		public BaseScriptableAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
