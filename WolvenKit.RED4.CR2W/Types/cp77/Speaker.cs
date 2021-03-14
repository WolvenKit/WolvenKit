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

		[Ordinal(93)] 
		[RED("soundEventPlaying")] 
		public CBool SoundEventPlaying
		{
			get
			{
				if (_soundEventPlaying == null)
				{
					_soundEventPlaying = (CBool) CR2WTypeManager.Create("Bool", "soundEventPlaying", cr2w, this);
				}
				return _soundEventPlaying;
			}
			set
			{
				if (_soundEventPlaying == value)
				{
					return;
				}
				_soundEventPlaying = value;
				PropertySet(this);
			}
		}

		[Ordinal(94)] 
		[RED("soundEvent")] 
		public CName SoundEvent
		{
			get
			{
				if (_soundEvent == null)
				{
					_soundEvent = (CName) CR2WTypeManager.Create("CName", "soundEvent", cr2w, this);
				}
				return _soundEvent;
			}
			set
			{
				if (_soundEvent == value)
				{
					return;
				}
				_soundEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(95)] 
		[RED("effectRef")] 
		public gameEffectRef EffectRef
		{
			get
			{
				if (_effectRef == null)
				{
					_effectRef = (gameEffectRef) CR2WTypeManager.Create("gameEffectRef", "effectRef", cr2w, this);
				}
				return _effectRef;
			}
			set
			{
				if (_effectRef == value)
				{
					return;
				}
				_effectRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(96)] 
		[RED("deafGameEffect")] 
		public CHandle<gameEffectInstance> DeafGameEffect
		{
			get
			{
				if (_deafGameEffect == null)
				{
					_deafGameEffect = (CHandle<gameEffectInstance>) CR2WTypeManager.Create("handle:gameEffectInstance", "deafGameEffect", cr2w, this);
				}
				return _deafGameEffect;
			}
			set
			{
				if (_deafGameEffect == value)
				{
					return;
				}
				_deafGameEffect = value;
				PropertySet(this);
			}
		}

		[Ordinal(97)] 
		[RED("targets")] 
		public CArray<wCHandle<ScriptedPuppet>> Targets
		{
			get
			{
				if (_targets == null)
				{
					_targets = (CArray<wCHandle<ScriptedPuppet>>) CR2WTypeManager.Create("array:whandle:ScriptedPuppet", "targets", cr2w, this);
				}
				return _targets;
			}
			set
			{
				if (_targets == value)
				{
					return;
				}
				_targets = value;
				PropertySet(this);
			}
		}

		[Ordinal(98)] 
		[RED("statusEffect")] 
		public TweakDBID StatusEffect
		{
			get
			{
				if (_statusEffect == null)
				{
					_statusEffect = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "statusEffect", cr2w, this);
				}
				return _statusEffect;
			}
			set
			{
				if (_statusEffect == value)
				{
					return;
				}
				_statusEffect = value;
				PropertySet(this);
			}
		}

		public Speaker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
