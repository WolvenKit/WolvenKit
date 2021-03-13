using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InvisibleSceneStash : Device
	{
		[Ordinal(86)] [RED("itemSlots")] public CArray<CEnum<gamedataEquipmentArea>> ItemSlots { get; set; }
		[Ordinal(87)] [RED("equipmentData")] public CHandle<EquipmentSystemPlayerData> EquipmentData { get; set; }

		public InvisibleSceneStash(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
