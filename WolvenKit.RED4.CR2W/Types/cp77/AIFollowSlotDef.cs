using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIFollowSlotDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("slotID")] public gamebbScriptID_Int32 SlotID { get; set; }
		[Ordinal(1)] [RED("slotTransform")] public gamebbScriptID_Variant SlotTransform { get; set; }

		public AIFollowSlotDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
