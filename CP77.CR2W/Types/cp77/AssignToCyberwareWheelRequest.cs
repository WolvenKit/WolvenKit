using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AssignToCyberwareWheelRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(2)] [RED("slotIndex")] public CInt32 SlotIndex { get; set; }

		public AssignToCyberwareWheelRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
