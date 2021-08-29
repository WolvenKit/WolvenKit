using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ExplosiveDeviceResourceDefinition : RedBaseClass
	{
		private TweakDBID _damageType;
		private gameFxResource _vfxResource;
		private CArray<CName> _vfxEventNamesOnExplosion;
		private CArray<gameFxResource> _vfxResourceOnFirstHit;
		private CFloat _executionDelay;
		private CEnum<EExplosiveAdditionalGameEffectType> _additionalGameEffectType;
		private CBool _dontHighlightOnLookat;

		[Ordinal(0)] 
		[RED("damageType")] 
		public TweakDBID DamageType
		{
			get => GetProperty(ref _damageType);
			set => SetProperty(ref _damageType, value);
		}

		[Ordinal(1)] 
		[RED("vfxResource")] 
		public gameFxResource VfxResource
		{
			get => GetProperty(ref _vfxResource);
			set => SetProperty(ref _vfxResource, value);
		}

		[Ordinal(2)] 
		[RED("vfxEventNamesOnExplosion")] 
		public CArray<CName> VfxEventNamesOnExplosion
		{
			get => GetProperty(ref _vfxEventNamesOnExplosion);
			set => SetProperty(ref _vfxEventNamesOnExplosion, value);
		}

		[Ordinal(3)] 
		[RED("vfxResourceOnFirstHit")] 
		public CArray<gameFxResource> VfxResourceOnFirstHit
		{
			get => GetProperty(ref _vfxResourceOnFirstHit);
			set => SetProperty(ref _vfxResourceOnFirstHit, value);
		}

		[Ordinal(4)] 
		[RED("executionDelay")] 
		public CFloat ExecutionDelay
		{
			get => GetProperty(ref _executionDelay);
			set => SetProperty(ref _executionDelay, value);
		}

		[Ordinal(5)] 
		[RED("additionalGameEffectType")] 
		public CEnum<EExplosiveAdditionalGameEffectType> AdditionalGameEffectType
		{
			get => GetProperty(ref _additionalGameEffectType);
			set => SetProperty(ref _additionalGameEffectType, value);
		}

		[Ordinal(6)] 
		[RED("dontHighlightOnLookat")] 
		public CBool DontHighlightOnLookat
		{
			get => GetProperty(ref _dontHighlightOnLookat);
			set => SetProperty(ref _dontHighlightOnLookat, value);
		}
	}
}
