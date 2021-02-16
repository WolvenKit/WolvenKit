using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameGlobalTierSaveData : CVariable
	{
		[Ordinal(0)] [RED("subtype")] public CEnum<gameGlobalTierSubtype> Subtype { get; set; }
		[Ordinal(1)] [RED("data")] public CHandle<gameSceneTierData> Data { get; set; }

		public gameGlobalTierSaveData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
