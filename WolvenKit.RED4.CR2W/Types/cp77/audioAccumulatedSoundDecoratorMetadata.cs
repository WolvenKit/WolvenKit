using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAccumulatedSoundDecoratorMetadata : audioEmitterMetadata
	{
		private CArray<CName> _accumulatedSounds;
		private CBool _inSpammingMode;
		private CName _fadeParam;
		private CFloat _soundTimeout;
		private CName _loopStart;
		private CName _loopEnd;
		private CName _spammingSound;
		private CFloat _spammingSoundInterval;

		[Ordinal(1)] 
		[RED("accumulatedSounds")] 
		public CArray<CName> AccumulatedSounds
		{
			get
			{
				if (_accumulatedSounds == null)
				{
					_accumulatedSounds = (CArray<CName>) CR2WTypeManager.Create("array:CName", "accumulatedSounds", cr2w, this);
				}
				return _accumulatedSounds;
			}
			set
			{
				if (_accumulatedSounds == value)
				{
					return;
				}
				_accumulatedSounds = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("inSpammingMode")] 
		public CBool InSpammingMode
		{
			get
			{
				if (_inSpammingMode == null)
				{
					_inSpammingMode = (CBool) CR2WTypeManager.Create("Bool", "inSpammingMode", cr2w, this);
				}
				return _inSpammingMode;
			}
			set
			{
				if (_inSpammingMode == value)
				{
					return;
				}
				_inSpammingMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("fadeParam")] 
		public CName FadeParam
		{
			get
			{
				if (_fadeParam == null)
				{
					_fadeParam = (CName) CR2WTypeManager.Create("CName", "fadeParam", cr2w, this);
				}
				return _fadeParam;
			}
			set
			{
				if (_fadeParam == value)
				{
					return;
				}
				_fadeParam = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("soundTimeout")] 
		public CFloat SoundTimeout
		{
			get
			{
				if (_soundTimeout == null)
				{
					_soundTimeout = (CFloat) CR2WTypeManager.Create("Float", "soundTimeout", cr2w, this);
				}
				return _soundTimeout;
			}
			set
			{
				if (_soundTimeout == value)
				{
					return;
				}
				_soundTimeout = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("loopStart")] 
		public CName LoopStart
		{
			get
			{
				if (_loopStart == null)
				{
					_loopStart = (CName) CR2WTypeManager.Create("CName", "loopStart", cr2w, this);
				}
				return _loopStart;
			}
			set
			{
				if (_loopStart == value)
				{
					return;
				}
				_loopStart = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("loopEnd")] 
		public CName LoopEnd
		{
			get
			{
				if (_loopEnd == null)
				{
					_loopEnd = (CName) CR2WTypeManager.Create("CName", "loopEnd", cr2w, this);
				}
				return _loopEnd;
			}
			set
			{
				if (_loopEnd == value)
				{
					return;
				}
				_loopEnd = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("spammingSound")] 
		public CName SpammingSound
		{
			get
			{
				if (_spammingSound == null)
				{
					_spammingSound = (CName) CR2WTypeManager.Create("CName", "spammingSound", cr2w, this);
				}
				return _spammingSound;
			}
			set
			{
				if (_spammingSound == value)
				{
					return;
				}
				_spammingSound = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("spammingSoundInterval")] 
		public CFloat SpammingSoundInterval
		{
			get
			{
				if (_spammingSoundInterval == null)
				{
					_spammingSoundInterval = (CFloat) CR2WTypeManager.Create("Float", "spammingSoundInterval", cr2w, this);
				}
				return _spammingSoundInterval;
			}
			set
			{
				if (_spammingSoundInterval == value)
				{
					return;
				}
				_spammingSoundInterval = value;
				PropertySet(this);
			}
		}

		public audioAccumulatedSoundDecoratorMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
