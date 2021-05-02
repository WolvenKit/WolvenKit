using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleDrawerEmitterOrientation : IParticleDrawer
	{
		private EulerAngles _coordinateSystem;
		private CBool _isGPUBased;

		[Ordinal(1)] 
		[RED("coordinateSystem")] 
		public EulerAngles CoordinateSystem
		{
			get => GetProperty(ref _coordinateSystem);
			set => SetProperty(ref _coordinateSystem, value);
		}

		[Ordinal(2)] 
		[RED("isGPUBased")] 
		public CBool IsGPUBased
		{
			get => GetProperty(ref _isGPUBased);
			set => SetProperty(ref _isGPUBased, value);
		}

		public CParticleDrawerEmitterOrientation(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
