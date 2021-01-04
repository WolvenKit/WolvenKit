using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIFollowSlotDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("slotID")] public gamebbScriptID_Int32 SlotID { get; set; }
		[Ordinal(1)]  [RED("slotTransform")] public gamebbScriptID_Variant SlotTransform { get; set; }

		public AIFollowSlotDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
