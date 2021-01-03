using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class workEquipItemToSlotAction : workIWorkspotItemAction
	{
		[Ordinal(0)]  [RED("item")] public TweakDBID Item { get; set; }
		[Ordinal(1)]  [RED("itemSlot")] public TweakDBID ItemSlot { get; set; }

		public workEquipItemToSlotAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
