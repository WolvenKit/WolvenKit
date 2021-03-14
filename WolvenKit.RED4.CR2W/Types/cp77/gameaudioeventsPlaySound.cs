using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioeventsPlaySound : redEvent
	{
		private CName _soundName;
		private CName _emitterName;
		private CName _audioTag;
		private CFloat _seekTime;
		private CBool _playUnique;

		[Ordinal(0)] 
		[RED("soundName")] 
		public CName SoundName
		{
			get
			{
				if (_soundName == null)
				{
					_soundName = (CName) CR2WTypeManager.Create("CName", "soundName", cr2w, this);
				}
				return _soundName;
			}
			set
			{
				if (_soundName == value)
				{
					return;
				}
				_soundName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("emitterName")] 
		public CName EmitterName
		{
			get
			{
				if (_emitterName == null)
				{
					_emitterName = (CName) CR2WTypeManager.Create("CName", "emitterName", cr2w, this);
				}
				return _emitterName;
			}
			set
			{
				if (_emitterName == value)
				{
					return;
				}
				_emitterName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("audioTag")] 
		public CName AudioTag
		{
			get
			{
				if (_audioTag == null)
				{
					_audioTag = (CName) CR2WTypeManager.Create("CName", "audioTag", cr2w, this);
				}
				return _audioTag;
			}
			set
			{
				if (_audioTag == value)
				{
					return;
				}
				_audioTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("seekTime")] 
		public CFloat SeekTime
		{
			get
			{
				if (_seekTime == null)
				{
					_seekTime = (CFloat) CR2WTypeManager.Create("Float", "seekTime", cr2w, this);
				}
				return _seekTime;
			}
			set
			{
				if (_seekTime == value)
				{
					return;
				}
				_seekTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("playUnique")] 
		public CBool PlayUnique
		{
			get
			{
				if (_playUnique == null)
				{
					_playUnique = (CBool) CR2WTypeManager.Create("Bool", "playUnique", cr2w, this);
				}
				return _playUnique;
			}
			set
			{
				if (_playUnique == value)
				{
					return;
				}
				_playUnique = value;
				PropertySet(this);
			}
		}

		public gameaudioeventsPlaySound(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
