using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CParticleInitializerRotationRate3D : IParticleInitializer
	{
		[Ordinal(0)]  [RED("rotationRate")] public CHandle<IEvaluatorVector> RotationRate { get; set; }

		public CParticleInitializerRotationRate3D(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
