using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsUnequipItemFromPerformerByItem : scnSceneEvent
	{
		[Ordinal(6)] [RED("performerId")] public scnPerformerId PerformerId { get; set; }
		[Ordinal(7)] [RED("itemId")] public TweakDBID ItemId { get; set; }
		[Ordinal(8)] [RED("restoreGameplayItem")] public CBool RestoreGameplayItem { get; set; }

		public scneventsUnequipItemFromPerformerByItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
