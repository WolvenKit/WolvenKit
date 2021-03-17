using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entParticlesComponent : entIVisualComponent
	{
		private CFloat _emissionRate;
		private rRef<CParticleSystem> _particleSystem;
		private CFloat _autoHideRange;
		private CEnum<RenderSceneLayerMask> _renderLayerMask;
		private CBool _isEnabled;

		[Ordinal(8)] 
		[RED("emissionRate")] 
		public CFloat EmissionRate
		{
			get => GetProperty(ref _emissionRate);
			set => SetProperty(ref _emissionRate, value);
		}

		[Ordinal(9)] 
		[RED("particleSystem")] 
		public rRef<CParticleSystem> ParticleSystem
		{
			get => GetProperty(ref _particleSystem);
			set => SetProperty(ref _particleSystem, value);
		}

		[Ordinal(10)] 
		[RED("autoHideRange")] 
		public CFloat AutoHideRange
		{
			get => GetProperty(ref _autoHideRange);
			set => SetProperty(ref _autoHideRange, value);
		}

		[Ordinal(11)] 
		[RED("renderLayerMask")] 
		public CEnum<RenderSceneLayerMask> RenderLayerMask
		{
			get => GetProperty(ref _renderLayerMask);
			set => SetProperty(ref _renderLayerMask, value);
		}

		[Ordinal(12)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		public entParticlesComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
