using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class BaseScriptableAction : gamedeviceAction
	{
		[Ordinal(0)]  [RED("executor")] public wCHandle<gameObject> Executor { get; set; }
		[Ordinal(1)]  [RED("inkWidgetID")] public TweakDBID InkWidgetID { get; set; }
		[Ordinal(2)]  [RED("interactionChoice")] public gameinteractionsChoice InteractionChoice { get; set; }
		[Ordinal(3)]  [RED("interactionLayer")] public CName InteractionLayer { get; set; }
		[Ordinal(4)]  [RED("isActionRPGCheckDissabled")] public CBool IsActionRPGCheckDissabled { get; set; }
		[Ordinal(5)]  [RED("objectActionID")] public TweakDBID ObjectActionID { get; set; }
		[Ordinal(6)]  [RED("objectActionRecord")] public wCHandle<gamedataObjectAction_Record> ObjectActionRecord { get; set; }
		[Ordinal(7)]  [RED("requesterID")] public entEntityID RequesterID { get; set; }

		public BaseScriptableAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
