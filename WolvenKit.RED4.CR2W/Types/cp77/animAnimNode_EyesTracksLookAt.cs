using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_EyesTracksLookAt : animAnimNode_OnePoseInput
	{
		private animTransformIndex _eyeTransform;
		private animNamedTrackIndex _leftTrack;
		private animNamedTrackIndex _rightTrack;
		private animNamedTrackIndex _upTrack;
		private animNamedTrackIndex _downTrack;
		private CBool _debug;

		[Ordinal(12)] 
		[RED("eyeTransform")] 
		public animTransformIndex EyeTransform
		{
			get
			{
				if (_eyeTransform == null)
				{
					_eyeTransform = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "eyeTransform", cr2w, this);
				}
				return _eyeTransform;
			}
			set
			{
				if (_eyeTransform == value)
				{
					return;
				}
				_eyeTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("leftTrack")] 
		public animNamedTrackIndex LeftTrack
		{
			get
			{
				if (_leftTrack == null)
				{
					_leftTrack = (animNamedTrackIndex) CR2WTypeManager.Create("animNamedTrackIndex", "leftTrack", cr2w, this);
				}
				return _leftTrack;
			}
			set
			{
				if (_leftTrack == value)
				{
					return;
				}
				_leftTrack = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("rightTrack")] 
		public animNamedTrackIndex RightTrack
		{
			get
			{
				if (_rightTrack == null)
				{
					_rightTrack = (animNamedTrackIndex) CR2WTypeManager.Create("animNamedTrackIndex", "rightTrack", cr2w, this);
				}
				return _rightTrack;
			}
			set
			{
				if (_rightTrack == value)
				{
					return;
				}
				_rightTrack = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("upTrack")] 
		public animNamedTrackIndex UpTrack
		{
			get
			{
				if (_upTrack == null)
				{
					_upTrack = (animNamedTrackIndex) CR2WTypeManager.Create("animNamedTrackIndex", "upTrack", cr2w, this);
				}
				return _upTrack;
			}
			set
			{
				if (_upTrack == value)
				{
					return;
				}
				_upTrack = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("downTrack")] 
		public animNamedTrackIndex DownTrack
		{
			get
			{
				if (_downTrack == null)
				{
					_downTrack = (animNamedTrackIndex) CR2WTypeManager.Create("animNamedTrackIndex", "downTrack", cr2w, this);
				}
				return _downTrack;
			}
			set
			{
				if (_downTrack == value)
				{
					return;
				}
				_downTrack = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("debug")] 
		public CBool Debug
		{
			get
			{
				if (_debug == null)
				{
					_debug = (CBool) CR2WTypeManager.Create("Bool", "debug", cr2w, this);
				}
				return _debug;
			}
			set
			{
				if (_debug == value)
				{
					return;
				}
				_debug = value;
				PropertySet(this);
			}
		}

		public animAnimNode_EyesTracksLookAt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
