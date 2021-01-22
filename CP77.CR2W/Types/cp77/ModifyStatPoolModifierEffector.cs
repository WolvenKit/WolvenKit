using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ModifyStatPoolModifierEffector : gameEffector
	{
		[Ordinal(0)]  [RED("modType")] public CEnum<gameStatPoolModificationTypes> ModType { get; set; }
		[Ordinal(1)]  [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(2)]  [RED("poolModifier")] public gameStatPoolModifier PoolModifier { get; set; }
		[Ordinal(3)]  [RED("poolType")] public CEnum<gamedataStatPoolType> PoolType { get; set; }
		[Ordinal(4)]  [RED("previousMod")] public gameStatPoolModifier PreviousMod { get; set; }

		public ModifyStatPoolModifierEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
