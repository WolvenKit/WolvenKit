using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleDrawerMotionBlur : IParticleDrawer
	{
		private CFloat _stretchPerVelocity;
		private CBool _isGPUBased;

		[Ordinal(1)] 
		[RED("stretchPerVelocity")] 
		public CFloat StretchPerVelocity
		{
			get => GetProperty(ref _stretchPerVelocity);
			set => SetProperty(ref _stretchPerVelocity, value);
		}

		[Ordinal(2)] 
		[RED("isGPUBased")] 
		public CBool IsGPUBased
		{
			get => GetProperty(ref _isGPUBased);
			set => SetProperty(ref _isGPUBased, value);
		}

		public CParticleDrawerMotionBlur(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
