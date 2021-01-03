using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CParticleEventGenerator : IParticleEvent
	{
		[Ordinal(0)]  [RED("evtType")] public CEnum<EParticleEventType> EvtType { get; set; }
		[Ordinal(1)]  [RED("frequency")] public CFloat Frequency { get; set; }
		[Ordinal(2)]  [RED("probability")] public CFloat Probability { get; set; }

		public CParticleEventGenerator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
