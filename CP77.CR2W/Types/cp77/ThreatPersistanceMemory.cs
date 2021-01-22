using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ThreatPersistanceMemory : CVariable
	{
		[Ordinal(0)]  [RED("isPersistent")] public CArray<CBool> IsPersistent { get; set; }
		[Ordinal(1)]  [RED("threats")] public CArray<wCHandle<entEntity>> Threats { get; set; }

		public ThreatPersistanceMemory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
