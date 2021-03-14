using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questHUDVideo_NodeType : questIUIManagerNodeType
	{
		private raRef<Bink> _video;
		private CBool _skippable;
		private CName _audioEvent;
		private CBool _syncToAudio;
		private CBool _retriggerAudioOnLoop;
		private CBool _looped;
		private CBool _forceVideoFrameRate;
		private CBool _playOnHud;
		private CBool _fullScreen;
		private Vector2 _position;
		private Vector2 _size;

		[Ordinal(0)] 
		[RED("video")] 
		public raRef<Bink> Video
		{
			get
			{
				if (_video == null)
				{
					_video = (raRef<Bink>) CR2WTypeManager.Create("raRef:Bink", "video", cr2w, this);
				}
				return _video;
			}
			set
			{
				if (_video == value)
				{
					return;
				}
				_video = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("skippable")] 
		public CBool Skippable
		{
			get
			{
				if (_skippable == null)
				{
					_skippable = (CBool) CR2WTypeManager.Create("Bool", "skippable", cr2w, this);
				}
				return _skippable;
			}
			set
			{
				if (_skippable == value)
				{
					return;
				}
				_skippable = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("audioEvent")] 
		public CName AudioEvent
		{
			get
			{
				if (_audioEvent == null)
				{
					_audioEvent = (CName) CR2WTypeManager.Create("CName", "audioEvent", cr2w, this);
				}
				return _audioEvent;
			}
			set
			{
				if (_audioEvent == value)
				{
					return;
				}
				_audioEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("syncToAudio")] 
		public CBool SyncToAudio
		{
			get
			{
				if (_syncToAudio == null)
				{
					_syncToAudio = (CBool) CR2WTypeManager.Create("Bool", "syncToAudio", cr2w, this);
				}
				return _syncToAudio;
			}
			set
			{
				if (_syncToAudio == value)
				{
					return;
				}
				_syncToAudio = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("retriggerAudioOnLoop")] 
		public CBool RetriggerAudioOnLoop
		{
			get
			{
				if (_retriggerAudioOnLoop == null)
				{
					_retriggerAudioOnLoop = (CBool) CR2WTypeManager.Create("Bool", "retriggerAudioOnLoop", cr2w, this);
				}
				return _retriggerAudioOnLoop;
			}
			set
			{
				if (_retriggerAudioOnLoop == value)
				{
					return;
				}
				_retriggerAudioOnLoop = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("looped")] 
		public CBool Looped
		{
			get
			{
				if (_looped == null)
				{
					_looped = (CBool) CR2WTypeManager.Create("Bool", "looped", cr2w, this);
				}
				return _looped;
			}
			set
			{
				if (_looped == value)
				{
					return;
				}
				_looped = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("forceVideoFrameRate")] 
		public CBool ForceVideoFrameRate
		{
			get
			{
				if (_forceVideoFrameRate == null)
				{
					_forceVideoFrameRate = (CBool) CR2WTypeManager.Create("Bool", "forceVideoFrameRate", cr2w, this);
				}
				return _forceVideoFrameRate;
			}
			set
			{
				if (_forceVideoFrameRate == value)
				{
					return;
				}
				_forceVideoFrameRate = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("playOnHud")] 
		public CBool PlayOnHud
		{
			get
			{
				if (_playOnHud == null)
				{
					_playOnHud = (CBool) CR2WTypeManager.Create("Bool", "playOnHud", cr2w, this);
				}
				return _playOnHud;
			}
			set
			{
				if (_playOnHud == value)
				{
					return;
				}
				_playOnHud = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("fullScreen")] 
		public CBool FullScreen
		{
			get
			{
				if (_fullScreen == null)
				{
					_fullScreen = (CBool) CR2WTypeManager.Create("Bool", "fullScreen", cr2w, this);
				}
				return _fullScreen;
			}
			set
			{
				if (_fullScreen == value)
				{
					return;
				}
				_fullScreen = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("position")] 
		public Vector2 Position
		{
			get
			{
				if (_position == null)
				{
					_position = (Vector2) CR2WTypeManager.Create("Vector2", "position", cr2w, this);
				}
				return _position;
			}
			set
			{
				if (_position == value)
				{
					return;
				}
				_position = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("size")] 
		public Vector2 Size
		{
			get
			{
				if (_size == null)
				{
					_size = (Vector2) CR2WTypeManager.Create("Vector2", "size", cr2w, this);
				}
				return _size;
			}
			set
			{
				if (_size == value)
				{
					return;
				}
				_size = value;
				PropertySet(this);
			}
		}

		public questHUDVideo_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
