using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameSLoadout : CVariable
	{
		[Ordinal(0)]  [RED("equipAreas")] public CArray<gameSEquipArea> EquipAreas { get; set; }
		[Ordinal(1)]  [RED("equipmentSets")] public CArray<gameSEquipmentSet> EquipmentSets { get; set; }

		public gameSLoadout(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
