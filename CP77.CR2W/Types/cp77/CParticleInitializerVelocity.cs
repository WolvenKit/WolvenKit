using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CParticleInitializerVelocity : IParticleInitializer
	{
		[Ordinal(0)]  [RED("scale")] public CFloat Scale { get; set; }
		[Ordinal(1)]  [RED("velocity")] public CHandle<IEvaluatorVector> Velocity { get; set; }
		[Ordinal(2)]  [RED("worldSpace")] public CBool WorldSpace { get; set; }

		public CParticleInitializerVelocity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
