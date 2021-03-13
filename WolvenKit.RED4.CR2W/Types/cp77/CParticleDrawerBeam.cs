using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleDrawerBeam : CParticleDrawerFacingBeam
	{
		[Ordinal(9)] [RED("rotation")] public CFloat Rotation { get; set; }

		public CParticleDrawerBeam(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
