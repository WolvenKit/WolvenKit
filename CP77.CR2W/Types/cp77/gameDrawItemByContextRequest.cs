using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameDrawItemByContextRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("equipAnimationType")] public CEnum<gameEquipAnimationType> EquipAnimationType { get; set; }
		[Ordinal(1)]  [RED("itemEquipContext")] public CEnum<gameItemEquipContexts> ItemEquipContext { get; set; }

		public gameDrawItemByContextRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
