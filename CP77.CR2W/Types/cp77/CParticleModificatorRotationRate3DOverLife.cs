using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorRotationRate3DOverLife : IParticleModificator
	{
		[Ordinal(0)]  [RED("rotationRate")] public CHandle<IEvaluatorVector> RotationRate { get; set; }

		public CParticleModificatorRotationRate3DOverLife(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
