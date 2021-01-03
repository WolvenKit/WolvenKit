using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorAlphaOverLife : IParticleModificator
	{
		[Ordinal(0)]  [RED("alpha")] public CHandle<IEvaluatorFloat> Alpha { get; set; }
		[Ordinal(1)]  [RED("modulate")] public CBool Modulate { get; set; }

		public CParticleModificatorAlphaOverLife(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
