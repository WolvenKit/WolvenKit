using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WeakspotOnDestroyProperties : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("isInternal")] 
		public CBool IsInternal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("disableInteraction")] 
		public CBool DisableInteraction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("destroyMesh")] 
		public CBool DestroyMesh
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("disableCollider")] 
		public CBool DisableCollider
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("hideMeshParameterValue")] 
		public CName HideMeshParameterValue
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("playHitFxFromOwnerEntity")] 
		public CBool PlayHitFxFromOwnerEntity
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("playDestroyedFxFromOwnerEntity")] 
		public CBool PlayDestroyedFxFromOwnerEntity
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("playBrokenFxFromOwnerEntity")] 
		public CBool PlayBrokenFxFromOwnerEntity
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("addFact")] 
		public CName AddFact
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("sendAIActionAnimFeatureName")] 
		public CName SendAIActionAnimFeatureName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("sendAIActionAnimFeatureState")] 
		public CInt32 SendAIActionAnimFeatureState
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(11)] 
		[RED("destroyDelay")] 
		public CFloat DestroyDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("useWeakspotDestroyStageVFX")] 
		public CBool UseWeakspotDestroyStageVFX
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("attackRecordID")] 
		public TweakDBID AttackRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(14)] 
		[RED("StatusEffectOnDestroyID")] 
		public TweakDBID StatusEffectOnDestroyID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public WeakspotOnDestroyProperties()
		{
			DisableInteraction = true;
			DestroyMesh = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
