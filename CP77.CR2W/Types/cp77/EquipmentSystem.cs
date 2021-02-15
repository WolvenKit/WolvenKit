using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class EquipmentSystem : gameScriptableSystem
	{
		[Ordinal(0)] [RED("ownerData")] public CArray<CHandle<EquipmentSystemPlayerData>> OwnerData { get; set; }

		public EquipmentSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
