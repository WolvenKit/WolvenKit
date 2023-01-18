using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ExplosiveDeviceResourceDefinition : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("damageType")] 
		public TweakDBID DamageType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("vfxResource")] 
		public gameFxResource VfxResource
		{
			get => GetPropertyValue<gameFxResource>();
			set => SetPropertyValue<gameFxResource>(value);
		}

		[Ordinal(2)] 
		[RED("vfxEventNamesOnExplosion")] 
		public CArray<CName> VfxEventNamesOnExplosion
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(3)] 
		[RED("vfxResourceOnFirstHit")] 
		public CArray<gameFxResource> VfxResourceOnFirstHit
		{
			get => GetPropertyValue<CArray<gameFxResource>>();
			set => SetPropertyValue<CArray<gameFxResource>>(value);
		}

		[Ordinal(4)] 
		[RED("executionDelay")] 
		public CFloat ExecutionDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("additionalGameEffectType")] 
		public CEnum<EExplosiveAdditionalGameEffectType> AdditionalGameEffectType
		{
			get => GetPropertyValue<CEnum<EExplosiveAdditionalGameEffectType>>();
			set => SetPropertyValue<CEnum<EExplosiveAdditionalGameEffectType>>(value);
		}

		[Ordinal(6)] 
		[RED("dontHighlightOnLookat")] 
		public CBool DontHighlightOnLookat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ExplosiveDeviceResourceDefinition()
		{
			VfxResource = new();
			VfxEventNamesOnExplosion = new();
			VfxResourceOnFirstHit = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
