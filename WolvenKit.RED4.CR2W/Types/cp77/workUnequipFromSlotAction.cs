using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workUnequipFromSlotAction : workIWorkspotItemAction
	{
		[Ordinal(0)] [RED("itemSlot")] public TweakDBID ItemSlot { get; set; }

		public workUnequipFromSlotAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
