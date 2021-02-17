using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameDrawItemRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(2)] [RED("equipAnimationType")] public CEnum<gameEquipAnimationType> EquipAnimationType { get; set; }
		[Ordinal(3)] [RED("assignOnly")] public CBool AssignOnly { get; set; }

		public gameDrawItemRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
