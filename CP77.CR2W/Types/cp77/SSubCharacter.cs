using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SSubCharacter : CVariable
	{
		[Ordinal(0)] [RED("persistentID")] public gamePersistentID PersistentID { get; set; }
		[Ordinal(1)] [RED("subCharType")] public CEnum<gamedataSubCharacter> SubCharType { get; set; }
		[Ordinal(2)] [RED("equipmentData")] public CHandle<EquipmentSystemPlayerData> EquipmentData { get; set; }

		public SSubCharacter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
