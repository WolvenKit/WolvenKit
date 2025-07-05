using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Radio : InteractiveDevice
	{
		[Ordinal(98)] 
		[RED("effectAction")] 
		public CHandle<ScriptableDeviceAction> EffectAction
		{
			get => GetPropertyValue<CHandle<ScriptableDeviceAction>>();
			set => SetPropertyValue<CHandle<ScriptableDeviceAction>>(value);
		}

		[Ordinal(99)] 
		[RED("effectRef")] 
		public gameEffectRef EffectRef
		{
			get => GetPropertyValue<gameEffectRef>();
			set => SetPropertyValue<gameEffectRef>(value);
		}

		[Ordinal(100)] 
		[RED("statusEffect")] 
		public TweakDBID StatusEffect
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(101)] 
		[RED("damageType")] 
		public TweakDBID DamageType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(102)] 
		[RED("startingStation")] 
		public CInt32 StartingStation
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(103)] 
		[RED("isInteractive")] 
		public CBool IsInteractive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(104)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(105)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(106)] 
		[RED("effectInstance")] 
		public CHandle<gameEffectInstance> EffectInstance
		{
			get => GetPropertyValue<CHandle<gameEffectInstance>>();
			set => SetPropertyValue<CHandle<gameEffectInstance>>(value);
		}

		[Ordinal(107)] 
		[RED("targets")] 
		public CArray<CWeakHandle<ScriptedPuppet>> Targets
		{
			get => GetPropertyValue<CArray<CWeakHandle<ScriptedPuppet>>>();
			set => SetPropertyValue<CArray<CWeakHandle<ScriptedPuppet>>>(value);
		}

		[Ordinal(108)] 
		[RED("vfxInstance")] 
		public CHandle<gameFxInstance> VfxInstance
		{
			get => GetPropertyValue<CHandle<gameFxInstance>>();
			set => SetPropertyValue<CHandle<gameFxInstance>>(value);
		}

		public Radio()
		{
			ControllerTypeName = "RadioController";
			EffectRef = new gameEffectRef();
			ShortGlitchDelayID = new gameDelayID();
			Targets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
