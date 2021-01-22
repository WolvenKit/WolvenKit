using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameStatData : CVariable
	{
		[Ordinal(0)]  [RED("modifiers")] public CArray<CHandle<gameStatModifierData>> Modifiers { get; set; }
		[Ordinal(1)]  [RED("statType")] public CEnum<gamedataStatType> StatType { get; set; }

		public gameStatData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
