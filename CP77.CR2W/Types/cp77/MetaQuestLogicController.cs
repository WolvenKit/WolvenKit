using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class MetaQuestLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("MetaQuest1")] public inkWidgetReference MetaQuest1 { get; set; }
		[Ordinal(1)]  [RED("MetaQuest1Value")] public inkTextWidgetReference MetaQuest1Value { get; set; }
		[Ordinal(2)]  [RED("MetaQuest2")] public inkWidgetReference MetaQuest2 { get; set; }
		[Ordinal(3)]  [RED("MetaQuest2Value")] public inkTextWidgetReference MetaQuest2Value { get; set; }
		[Ordinal(4)]  [RED("MetaQuest3")] public inkWidgetReference MetaQuest3 { get; set; }
		[Ordinal(5)]  [RED("MetaQuest3Value")] public inkTextWidgetReference MetaQuest3Value { get; set; }
		[Ordinal(6)]  [RED("MetaQuestHint")] public inkWidgetReference MetaQuestHint { get; set; }
		[Ordinal(7)]  [RED("MetaQuestHintText")] public inkTextWidgetReference MetaQuestHintText { get; set; }
		[Ordinal(8)]  [RED("animMeta1")] public CHandle<inkanimProxy> AnimMeta1 { get; set; }
		[Ordinal(9)]  [RED("animMeta2")] public CHandle<inkanimProxy> AnimMeta2 { get; set; }
		[Ordinal(10)]  [RED("animMeta3")] public CHandle<inkanimProxy> AnimMeta3 { get; set; }
		[Ordinal(11)]  [RED("animTooltip")] public CHandle<inkanimProxy> AnimTooltip { get; set; }
		[Ordinal(12)]  [RED("metaQuest1Description")] public CString MetaQuest1Description { get; set; }
		[Ordinal(13)]  [RED("metaQuest2Description")] public CString MetaQuest2Description { get; set; }
		[Ordinal(14)]  [RED("metaQuest3Description")] public CString MetaQuest3Description { get; set; }

		public MetaQuestLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
