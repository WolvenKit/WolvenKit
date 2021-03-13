using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleDrawerMotionBlur : IParticleDrawer
	{
		[Ordinal(1)] [RED("stretchPerVelocity")] public CFloat StretchPerVelocity { get; set; }
		[Ordinal(2)] [RED("isGPUBased")] public CBool IsGPUBased { get; set; }

		public CParticleDrawerMotionBlur(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
