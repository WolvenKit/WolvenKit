using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnAudioDurationEvent : scnSceneEvent
	{
		private scnPerformerId _performer;
		private CName _audioEventName;
		private CEnum<scnAudioPlaybackDirectionSupportFlag> _playbackDirectionSupport;

		[Ordinal(6)] 
		[RED("performer")] 
		public scnPerformerId Performer
		{
			get
			{
				if (_performer == null)
				{
					_performer = (scnPerformerId) CR2WTypeManager.Create("scnPerformerId", "performer", cr2w, this);
				}
				return _performer;
			}
			set
			{
				if (_performer == value)
				{
					return;
				}
				_performer = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("audioEventName")] 
		public CName AudioEventName
		{
			get
			{
				if (_audioEventName == null)
				{
					_audioEventName = (CName) CR2WTypeManager.Create("CName", "audioEventName", cr2w, this);
				}
				return _audioEventName;
			}
			set
			{
				if (_audioEventName == value)
				{
					return;
				}
				_audioEventName = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("playbackDirectionSupport")] 
		public CEnum<scnAudioPlaybackDirectionSupportFlag> PlaybackDirectionSupport
		{
			get
			{
				if (_playbackDirectionSupport == null)
				{
					_playbackDirectionSupport = (CEnum<scnAudioPlaybackDirectionSupportFlag>) CR2WTypeManager.Create("scnAudioPlaybackDirectionSupportFlag", "playbackDirectionSupport", cr2w, this);
				}
				return _playbackDirectionSupport;
			}
			set
			{
				if (_playbackDirectionSupport == value)
				{
					return;
				}
				_playbackDirectionSupport = value;
				PropertySet(this);
			}
		}

		public scnAudioDurationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
