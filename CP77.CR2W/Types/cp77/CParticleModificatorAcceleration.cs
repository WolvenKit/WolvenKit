using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorAcceleration : IParticleModificator
	{
		[Ordinal(4)] [RED("direction")] public CHandle<IEvaluatorVector> Direction { get; set; }
		[Ordinal(5)] [RED("scale")] public CHandle<IEvaluatorFloat> Scale { get; set; }
		[Ordinal(6)] [RED("worldSpace")] public CBool WorldSpace { get; set; }

		public CParticleModificatorAcceleration(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
