using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimation : ISerializable
	{
		private redTagList _tags;
		private CName _name;
		private CFloat _duration;
		private CEnum<animAnimationType> _animationType;
		private CHandle<animIAnimationBuffer> _animBuffer;
		private animAdditionalTransformContainer _additionalTransforms;
		private animAdditionalFloatTrackContainer _additionalTracks;
		private CHandle<animIMotionExtraction> _motionExtraction;
		private CBool _frameClamping;
		private CInt8 _frameClampingStartFrame;
		private CInt8 _frameClampingEndFrame;

		[Ordinal(0)] 
		[RED("tags")] 
		public redTagList Tags
		{
			get
			{
				if (_tags == null)
				{
					_tags = (redTagList) CR2WTypeManager.Create("redTagList", "tags", cr2w, this);
				}
				return _tags;
			}
			set
			{
				if (_tags == value)
				{
					return;
				}
				_tags = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("animationType")] 
		public CEnum<animAnimationType> AnimationType
		{
			get
			{
				if (_animationType == null)
				{
					_animationType = (CEnum<animAnimationType>) CR2WTypeManager.Create("animAnimationType", "animationType", cr2w, this);
				}
				return _animationType;
			}
			set
			{
				if (_animationType == value)
				{
					return;
				}
				_animationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("animBuffer")] 
		public CHandle<animIAnimationBuffer> AnimBuffer
		{
			get
			{
				if (_animBuffer == null)
				{
					_animBuffer = (CHandle<animIAnimationBuffer>) CR2WTypeManager.Create("handle:animIAnimationBuffer", "animBuffer", cr2w, this);
				}
				return _animBuffer;
			}
			set
			{
				if (_animBuffer == value)
				{
					return;
				}
				_animBuffer = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("additionalTransforms")] 
		public animAdditionalTransformContainer AdditionalTransforms
		{
			get
			{
				if (_additionalTransforms == null)
				{
					_additionalTransforms = (animAdditionalTransformContainer) CR2WTypeManager.Create("animAdditionalTransformContainer", "additionalTransforms", cr2w, this);
				}
				return _additionalTransforms;
			}
			set
			{
				if (_additionalTransforms == value)
				{
					return;
				}
				_additionalTransforms = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("additionalTracks")] 
		public animAdditionalFloatTrackContainer AdditionalTracks
		{
			get
			{
				if (_additionalTracks == null)
				{
					_additionalTracks = (animAdditionalFloatTrackContainer) CR2WTypeManager.Create("animAdditionalFloatTrackContainer", "additionalTracks", cr2w, this);
				}
				return _additionalTracks;
			}
			set
			{
				if (_additionalTracks == value)
				{
					return;
				}
				_additionalTracks = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("motionExtraction")] 
		public CHandle<animIMotionExtraction> MotionExtraction
		{
			get
			{
				if (_motionExtraction == null)
				{
					_motionExtraction = (CHandle<animIMotionExtraction>) CR2WTypeManager.Create("handle:animIMotionExtraction", "motionExtraction", cr2w, this);
				}
				return _motionExtraction;
			}
			set
			{
				if (_motionExtraction == value)
				{
					return;
				}
				_motionExtraction = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("frameClamping")] 
		public CBool FrameClamping
		{
			get
			{
				if (_frameClamping == null)
				{
					_frameClamping = (CBool) CR2WTypeManager.Create("Bool", "frameClamping", cr2w, this);
				}
				return _frameClamping;
			}
			set
			{
				if (_frameClamping == value)
				{
					return;
				}
				_frameClamping = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("frameClampingStartFrame")] 
		public CInt8 FrameClampingStartFrame
		{
			get
			{
				if (_frameClampingStartFrame == null)
				{
					_frameClampingStartFrame = (CInt8) CR2WTypeManager.Create("Int8", "frameClampingStartFrame", cr2w, this);
				}
				return _frameClampingStartFrame;
			}
			set
			{
				if (_frameClampingStartFrame == value)
				{
					return;
				}
				_frameClampingStartFrame = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("frameClampingEndFrame")] 
		public CInt8 FrameClampingEndFrame
		{
			get
			{
				if (_frameClampingEndFrame == null)
				{
					_frameClampingEndFrame = (CInt8) CR2WTypeManager.Create("Int8", "frameClampingEndFrame", cr2w, this);
				}
				return _frameClampingEndFrame;
			}
			set
			{
				if (_frameClampingEndFrame == value)
				{
					return;
				}
				_frameClampingEndFrame = value;
				PropertySet(this);
			}
		}

		public animAnimation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
