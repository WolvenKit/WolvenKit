using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameDrawItemByContextRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] [RED("itemEquipContext")] public CEnum<gameItemEquipContexts> ItemEquipContext { get; set; }
		[Ordinal(2)] [RED("equipAnimationType")] public CEnum<gameEquipAnimationType> EquipAnimationType { get; set; }

		public gameDrawItemByContextRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
