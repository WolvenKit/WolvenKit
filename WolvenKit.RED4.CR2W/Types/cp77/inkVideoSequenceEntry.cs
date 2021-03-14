using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkVideoSequenceEntry : CVariable
	{
		private raRef<Bink> _videoResource;
		private CName _audioEvent;
		private CBool _syncToAudio;
		private CBool _retriggerAudioOnLoop;
		private CBool _loop;

		[Ordinal(0)] 
		[RED("videoResource")] 
		public raRef<Bink> VideoResource
		{
			get
			{
				if (_videoResource == null)
				{
					_videoResource = (raRef<Bink>) CR2WTypeManager.Create("raRef:Bink", "videoResource", cr2w, this);
				}
				return _videoResource;
			}
			set
			{
				if (_videoResource == value)
				{
					return;
				}
				_videoResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
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

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("loop")] 
		public CBool Loop
		{
			get
			{
				if (_loop == null)
				{
					_loop = (CBool) CR2WTypeManager.Create("Bool", "loop", cr2w, this);
				}
				return _loop;
			}
			set
			{
				if (_loop == value)
				{
					return;
				}
				_loop = value;
				PropertySet(this);
			}
		}

		public inkVideoSequenceEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
