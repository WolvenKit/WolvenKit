using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiPlayerBioMonitor : CVariable
	{
		[Ordinal(0)]  [RED("currentHealth")] public CInt32 CurrentHealth { get; set; }
		[Ordinal(1)]  [RED("maximumHealth")] public CInt32 MaximumHealth { get; set; }
		[Ordinal(2)]  [RED("currentCyberwarePct")] public CInt32 CurrentCyberwarePct { get; set; }
		[Ordinal(3)]  [RED("currentArmor")] public CInt32 CurrentArmor { get; set; }
		[Ordinal(4)]  [RED("maximumArmor")] public CInt32 MaximumArmor { get; set; }

		public gameuiPlayerBioMonitor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
