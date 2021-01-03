using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameSEquipmentSet : CVariable
	{
		[Ordinal(0)]  [RED("setItems")] public CArray<gameSItemInfo> SetItems { get; set; }
		[Ordinal(1)]  [RED("setName")] public CName SetName { get; set; }
		[Ordinal(2)]  [RED("setType")] public CEnum<gameEquipmentSetType> SetType { get; set; }

		public gameSEquipmentSet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
