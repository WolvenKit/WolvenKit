using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkFrameAnimByTrack : animAnimNode_SkFrameAnim
	{
		private animNamedTrackIndex _progressFloatTrack;
		private animNamedTrackIndex _timeFloatTrack;
		private animNamedTrackIndex _frameFloatTrack;
		private animPoseLink _inputWithTracks;

		[Ordinal(34)] 
		[RED("progressFloatTrack")] 
		public animNamedTrackIndex ProgressFloatTrack
		{
			get
			{
				if (_progressFloatTrack == null)
				{
					_progressFloatTrack = (animNamedTrackIndex) CR2WTypeManager.Create("animNamedTrackIndex", "progressFloatTrack", cr2w, this);
				}
				return _progressFloatTrack;
			}
			set
			{
				if (_progressFloatTrack == value)
				{
					return;
				}
				_progressFloatTrack = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("timeFloatTrack")] 
		public animNamedTrackIndex TimeFloatTrack
		{
			get
			{
				if (_timeFloatTrack == null)
				{
					_timeFloatTrack = (animNamedTrackIndex) CR2WTypeManager.Create("animNamedTrackIndex", "timeFloatTrack", cr2w, this);
				}
				return _timeFloatTrack;
			}
			set
			{
				if (_timeFloatTrack == value)
				{
					return;
				}
				_timeFloatTrack = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("frameFloatTrack")] 
		public animNamedTrackIndex FrameFloatTrack
		{
			get
			{
				if (_frameFloatTrack == null)
				{
					_frameFloatTrack = (animNamedTrackIndex) CR2WTypeManager.Create("animNamedTrackIndex", "frameFloatTrack", cr2w, this);
				}
				return _frameFloatTrack;
			}
			set
			{
				if (_frameFloatTrack == value)
				{
					return;
				}
				_frameFloatTrack = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("inputWithTracks")] 
		public animPoseLink InputWithTracks
		{
			get
			{
				if (_inputWithTracks == null)
				{
					_inputWithTracks = (animPoseLink) CR2WTypeManager.Create("animPoseLink", "inputWithTracks", cr2w, this);
				}
				return _inputWithTracks;
			}
			set
			{
				if (_inputWithTracks == value)
				{
					return;
				}
				_inputWithTracks = value;
				PropertySet(this);
			}
		}

		public animAnimNode_SkFrameAnimByTrack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
