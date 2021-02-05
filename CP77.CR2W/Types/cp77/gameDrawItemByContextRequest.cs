using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameDrawItemByContextRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("itemEquipContext")] public CEnum<gameItemEquipContexts> ItemEquipContext { get; set; }
		[Ordinal(1)]  [RED("equipAnimationType")] public CEnum<gameEquipAnimationType> EquipAnimationType { get; set; }

		public gameDrawItemByContextRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
