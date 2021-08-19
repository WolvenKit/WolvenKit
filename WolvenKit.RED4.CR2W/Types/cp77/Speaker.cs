using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Speaker : InteractiveDevice
	{
		private CBool _soundEventPlaying;
		private CName _soundEvent;
		private gameEffectRef _effectRef;
		private CHandle<gameEffectInstance> _deafGameEffect;
		private CArray<wCHandle<ScriptedPuppet>> _targets;
		private TweakDBID _statusEffect;

		[Ordinal(97)] 
		[RED("soundEventPlaying")] 
		public CBool SoundEventPlaying
		{
			get => GetProperty(ref _soundEventPlaying);
			set => SetProperty(ref _soundEventPlaying, value);
		}

		[Ordinal(98)] 
		[RED("soundEvent")] 
		public CName SoundEvent
		{
			get => GetProperty(ref _soundEvent);
			set => SetProperty(ref _soundEvent, value);
		}

		[Ordinal(99)] 
		[RED("effectRef")] 
		public gameEffectRef EffectRef
		{
			get => GetProperty(ref _effectRef);
			set => SetProperty(ref _effectRef, value);
		}

		[Ordinal(100)] 
		[RED("deafGameEffect")] 
		public CHandle<gameEffectInstance> DeafGameEffect
		{
			get => GetProperty(ref _deafGameEffect);
			set => SetProperty(ref _deafGameEffect, value);
		}

		[Ordinal(101)] 
		[RED("targets")] 
		public CArray<wCHandle<ScriptedPuppet>> Targets
		{
			get => GetProperty(ref _targets);
			set => SetProperty(ref _targets, value);
		}

		[Ordinal(102)] 
		[RED("statusEffect")] 
		public TweakDBID StatusEffect
		{
			get => GetProperty(ref _statusEffect);
			set => SetProperty(ref _statusEffect, value);
		}

		public Speaker(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
