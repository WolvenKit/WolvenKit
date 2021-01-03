using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorRotation3DOverLife : IParticleModificator
	{
		[Ordinal(0)]  [RED("modulate")] public CBool Modulate { get; set; }
		[Ordinal(1)]  [RED("rotation")] public CHandle<IEvaluatorVector> Rotation { get; set; }

		public CParticleModificatorRotation3DOverLife(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
