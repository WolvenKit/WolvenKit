using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorSizeOverLife : IParticleModificator
	{
		[Ordinal(4)] [RED("size")] public CHandle<IEvaluatorVector> Size { get; set; }
		[Ordinal(5)] [RED("scale")] public CFloat Scale { get; set; }
		[Ordinal(6)] [RED("modulate")] public CBool Modulate { get; set; }

		public CParticleModificatorSizeOverLife(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
