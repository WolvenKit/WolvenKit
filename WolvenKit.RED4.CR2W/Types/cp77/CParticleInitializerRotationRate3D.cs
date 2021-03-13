using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleInitializerRotationRate3D : IParticleInitializer
	{
		[Ordinal(4)] [RED("rotationRate")] public CHandle<IEvaluatorVector> RotationRate { get; set; }

		public CParticleInitializerRotationRate3D(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
