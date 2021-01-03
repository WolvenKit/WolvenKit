using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameStatModifierSave : CVariable
	{
		[Ordinal(0)]  [RED("recordID")] public TweakDBID RecordID { get; set; }
		[Ordinal(1)]  [RED("seed")] public CUInt32 Seed { get; set; }
		[Ordinal(2)]  [RED("statModifierUnions")] public CArray<CHandle<gameStatModifierData>> StatModifierUnions { get; set; }
		[Ordinal(3)]  [RED("statsObjectID")] public gameStatsObjectID StatsObjectID { get; set; }

		public gameStatModifierSave(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
