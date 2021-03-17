using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleDrawerSphereAligned : IParticleDrawer
	{
		private CBool _verticalFixed;
		private CBool _isGPUBased;

		[Ordinal(1)] 
		[RED("verticalFixed")] 
		public CBool VerticalFixed
		{
			get => GetProperty(ref _verticalFixed);
			set => SetProperty(ref _verticalFixed, value);
		}

		[Ordinal(2)] 
		[RED("isGPUBased")] 
		public CBool IsGPUBased
		{
			get => GetProperty(ref _isGPUBased);
			set => SetProperty(ref _isGPUBased, value);
		}

		public CParticleDrawerSphereAligned(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
