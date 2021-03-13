using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleDrawerEmitterOrientation : IParticleDrawer
	{
		[Ordinal(1)] [RED("coordinateSystem")] public EulerAngles CoordinateSystem { get; set; }
		[Ordinal(2)] [RED("isGPUBased")] public CBool IsGPUBased { get; set; }

		public CParticleDrawerEmitterOrientation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
