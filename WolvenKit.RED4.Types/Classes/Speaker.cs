using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Speaker : InteractiveDevice
	{
		[Ordinal(97)] 
		[RED("soundEventPlaying")] 
		public CBool SoundEventPlaying
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(98)] 
		[RED("soundEvent")] 
		public CName SoundEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(99)] 
		[RED("effectRef")] 
		public gameEffectRef EffectRef
		{
			get => GetPropertyValue<gameEffectRef>();
			set => SetPropertyValue<gameEffectRef>(value);
		}

		[Ordinal(100)] 
		[RED("deafGameEffect")] 
		public CHandle<gameEffectInstance> DeafGameEffect
		{
			get => GetPropertyValue<CHandle<gameEffectInstance>>();
			set => SetPropertyValue<CHandle<gameEffectInstance>>(value);
		}

		[Ordinal(101)] 
		[RED("targets")] 
		public CArray<CWeakHandle<ScriptedPuppet>> Targets
		{
			get => GetPropertyValue<CArray<CWeakHandle<ScriptedPuppet>>>();
			set => SetPropertyValue<CArray<CWeakHandle<ScriptedPuppet>>>(value);
		}

		[Ordinal(102)] 
		[RED("statusEffect")] 
		public TweakDBID StatusEffect
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public Speaker()
		{
			ControllerTypeName = "SpeakerController";
			EffectRef = new();
			Targets = new();
		}
	}
}
