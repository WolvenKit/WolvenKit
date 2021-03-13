using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleDrawerBillboard : IParticleDrawer
	{
		[Ordinal(1)] [RED("isGPUBased")] public CBool IsGPUBased { get; set; }

		public CParticleDrawerBillboard(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
