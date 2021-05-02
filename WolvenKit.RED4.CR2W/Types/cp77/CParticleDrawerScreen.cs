using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleDrawerScreen : IParticleDrawer
	{
		private CBool _isGPUBased;

		[Ordinal(1)] 
		[RED("isGPUBased")] 
		public CBool IsGPUBased
		{
			get => GetProperty(ref _isGPUBased);
			set => SetProperty(ref _isGPUBased, value);
		}

		public CParticleDrawerScreen(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
