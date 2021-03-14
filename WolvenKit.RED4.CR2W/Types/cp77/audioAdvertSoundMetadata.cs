using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAdvertSoundMetadata : audioAudioMetadata
	{
		private CName _audioEvent1;
		private CName _audioEvent2;
		private CName _audioEvent3;
		private CName _audioEvent4;
		private CBool _useCustomDelays;
		private CFloat _speedOfSound;
		private CFloat _soundDelay1;
		private CFloat _soundDelay2;
		private CFloat _soundDelay3;
		private CFloat _soundDelay4;

		[Ordinal(1)] 
		[RED("audioEvent1")] 
		public CName AudioEvent1
		{
			get
			{
				if (_audioEvent1 == null)
				{
					_audioEvent1 = (CName) CR2WTypeManager.Create("CName", "audioEvent1", cr2w, this);
				}
				return _audioEvent1;
			}
			set
			{
				if (_audioEvent1 == value)
				{
					return;
				}
				_audioEvent1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("audioEvent2")] 
		public CName AudioEvent2
		{
			get
			{
				if (_audioEvent2 == null)
				{
					_audioEvent2 = (CName) CR2WTypeManager.Create("CName", "audioEvent2", cr2w, this);
				}
				return _audioEvent2;
			}
			set
			{
				if (_audioEvent2 == value)
				{
					return;
				}
				_audioEvent2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("audioEvent3")] 
		public CName AudioEvent3
		{
			get
			{
				if (_audioEvent3 == null)
				{
					_audioEvent3 = (CName) CR2WTypeManager.Create("CName", "audioEvent3", cr2w, this);
				}
				return _audioEvent3;
			}
			set
			{
				if (_audioEvent3 == value)
				{
					return;
				}
				_audioEvent3 = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("audioEvent4")] 
		public CName AudioEvent4
		{
			get
			{
				if (_audioEvent4 == null)
				{
					_audioEvent4 = (CName) CR2WTypeManager.Create("CName", "audioEvent4", cr2w, this);
				}
				return _audioEvent4;
			}
			set
			{
				if (_audioEvent4 == value)
				{
					return;
				}
				_audioEvent4 = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("useCustomDelays")] 
		public CBool UseCustomDelays
		{
			get
			{
				if (_useCustomDelays == null)
				{
					_useCustomDelays = (CBool) CR2WTypeManager.Create("Bool", "useCustomDelays", cr2w, this);
				}
				return _useCustomDelays;
			}
			set
			{
				if (_useCustomDelays == value)
				{
					return;
				}
				_useCustomDelays = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("speedOfSound")] 
		public CFloat SpeedOfSound
		{
			get
			{
				if (_speedOfSound == null)
				{
					_speedOfSound = (CFloat) CR2WTypeManager.Create("Float", "speedOfSound", cr2w, this);
				}
				return _speedOfSound;
			}
			set
			{
				if (_speedOfSound == value)
				{
					return;
				}
				_speedOfSound = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("soundDelay1")] 
		public CFloat SoundDelay1
		{
			get
			{
				if (_soundDelay1 == null)
				{
					_soundDelay1 = (CFloat) CR2WTypeManager.Create("Float", "soundDelay1", cr2w, this);
				}
				return _soundDelay1;
			}
			set
			{
				if (_soundDelay1 == value)
				{
					return;
				}
				_soundDelay1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("soundDelay2")] 
		public CFloat SoundDelay2
		{
			get
			{
				if (_soundDelay2 == null)
				{
					_soundDelay2 = (CFloat) CR2WTypeManager.Create("Float", "soundDelay2", cr2w, this);
				}
				return _soundDelay2;
			}
			set
			{
				if (_soundDelay2 == value)
				{
					return;
				}
				_soundDelay2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("soundDelay3")] 
		public CFloat SoundDelay3
		{
			get
			{
				if (_soundDelay3 == null)
				{
					_soundDelay3 = (CFloat) CR2WTypeManager.Create("Float", "soundDelay3", cr2w, this);
				}
				return _soundDelay3;
			}
			set
			{
				if (_soundDelay3 == value)
				{
					return;
				}
				_soundDelay3 = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("soundDelay4")] 
		public CFloat SoundDelay4
		{
			get
			{
				if (_soundDelay4 == null)
				{
					_soundDelay4 = (CFloat) CR2WTypeManager.Create("Float", "soundDelay4", cr2w, this);
				}
				return _soundDelay4;
			}
			set
			{
				if (_soundDelay4 == value)
				{
					return;
				}
				_soundDelay4 = value;
				PropertySet(this);
			}
		}

		public audioAdvertSoundMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
