using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ThreatPersistanceMemory : CVariable
	{
		[Ordinal(0)]  [RED("isPersistent")] public CArray<CBool> IsPersistent { get; set; }
		[Ordinal(1)]  [RED("threats")] public CArray<wCHandle<entEntity>> Threats { get; set; }

		public ThreatPersistanceMemory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
