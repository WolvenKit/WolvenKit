using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class rendEmitterLOD : CVariable
	{
		[Ordinal(0)]  [RED("birthRate")] public CArray<CFloat> BirthRate { get; set; }
		[Ordinal(1)]  [RED("burstList")] public CArray<rendParticleBurst> BurstList { get; set; }
		[Ordinal(2)]  [RED("emitterDelaySettings")] public rendEmitterDelaySettings EmitterDelaySettings { get; set; }
		[Ordinal(3)]  [RED("emitterDurationSettings")] public rendEmitterDurationSettings EmitterDurationSettings { get; set; }
		[Ordinal(4)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(5)]  [RED("lodSwitchDistance")] public CFloat LodSwitchDistance { get; set; }
		[Ordinal(6)]  [RED("sortingMode")] public CEnum<rendEParticleSortingMode> SortingMode { get; set; }

		public rendEmitterLOD(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
