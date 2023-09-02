using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Speaker : InteractiveDevice
	{
		[Ordinal(94)] 
		[RED("soundEventPlaying")] 
		public CBool SoundEventPlaying
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(95)] 
		[RED("soundEvent")] 
		public CName SoundEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(96)] 
		[RED("effectRef")] 
		public gameEffectRef EffectRef
		{
			get => GetPropertyValue<gameEffectRef>();
			set => SetPropertyValue<gameEffectRef>(value);
		}

		[Ordinal(97)] 
		[RED("deafGameEffect")] 
		public CHandle<gameEffectInstance> DeafGameEffect
		{
			get => GetPropertyValue<CHandle<gameEffectInstance>>();
			set => SetPropertyValue<CHandle<gameEffectInstance>>(value);
		}

		[Ordinal(98)] 
		[RED("targets")] 
		public CArray<CWeakHandle<ScriptedPuppet>> Targets
		{
			get => GetPropertyValue<CArray<CWeakHandle<ScriptedPuppet>>>();
			set => SetPropertyValue<CArray<CWeakHandle<ScriptedPuppet>>>(value);
		}

		[Ordinal(99)] 
		[RED("statusEffect")] 
		public TweakDBID StatusEffect
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public Speaker()
		{
			ControllerTypeName = "SpeakerController";
			EffectRef = new gameEffectRef();
			Targets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
