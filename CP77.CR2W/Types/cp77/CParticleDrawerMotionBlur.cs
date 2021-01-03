using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CParticleDrawerMotionBlur : IParticleDrawer
	{
		[Ordinal(0)]  [RED("isGPUBased")] public CBool IsGPUBased { get; set; }
		[Ordinal(1)]  [RED("stretchPerVelocity")] public CFloat StretchPerVelocity { get; set; }

		public CParticleDrawerMotionBlur(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
