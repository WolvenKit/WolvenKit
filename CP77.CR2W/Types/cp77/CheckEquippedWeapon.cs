using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CheckEquippedWeapon : AIItemHandlingCondition
	{
		[Ordinal(0)]  [RED("itemID")] public CHandle<AIArgumentMapping> ItemID { get; set; }
		[Ordinal(1)]  [RED("itemIDName")] public TweakDBID ItemIDName { get; set; }
		[Ordinal(2)]  [RED("slotID")] public CHandle<AIArgumentMapping> SlotID { get; set; }
		[Ordinal(3)]  [RED("slotIDName")] public TweakDBID SlotIDName { get; set; }

		public CheckEquippedWeapon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
