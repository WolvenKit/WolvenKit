using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleInitializerPosition : IParticleInitializer
	{
		[Ordinal(0)]  [RED("offset")] public CFloat Offset { get; set; }
		[Ordinal(1)]  [RED("position")] public CHandle<IEvaluatorVector> Position { get; set; }
		[Ordinal(2)]  [RED("worldSpace")] public CBool WorldSpace { get; set; }

		public CParticleInitializerPosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
