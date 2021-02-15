using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleInitializerSize : IParticleInitializer
	{
		[Ordinal(4)] [RED("size")] public CHandle<IEvaluatorVector> Size { get; set; }
		[Ordinal(5)] [RED("scale")] public CFloat Scale { get; set; }

		public CParticleInitializerSize(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
