using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class InvisibleSceneStash : Device
	{
		[Ordinal(0)]  [RED("equipmentData")] public CHandle<EquipmentSystemPlayerData> EquipmentData { get; set; }
		[Ordinal(1)]  [RED("itemSlots")] public CArray<CEnum<gamedataEquipmentArea>> ItemSlots { get; set; }

		public InvisibleSceneStash(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
