using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class OdaEmergencyListener : gameCustomValueStatPoolsListener
	{
		[Ordinal(0)] [RED("owner")] public wCHandle<NPCPuppet> Owner { get; set; }
		[Ordinal(1)] [RED("healNumber")] public CInt32 HealNumber { get; set; }
		[Ordinal(2)] [RED("heal1HealthPercentage")] public CFloat Heal1HealthPercentage { get; set; }
		[Ordinal(3)] [RED("heal2HealthPercentage")] public CFloat Heal2HealthPercentage { get; set; }
		[Ordinal(4)] [RED("heal3HealthPercentage")] public CFloat Heal3HealthPercentage { get; set; }
		[Ordinal(5)] [RED("heal4HealthPercentage")] public CFloat Heal4HealthPercentage { get; set; }
		[Ordinal(6)] [RED("heal5HealthPercentage")] public CFloat Heal5HealthPercentage { get; set; }

		public OdaEmergencyListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
