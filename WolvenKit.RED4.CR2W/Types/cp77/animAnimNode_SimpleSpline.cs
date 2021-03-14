using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SimpleSpline : animAnimNode_OnePoseInput
	{
		private CBool _areSourceChannelsResaved;
		private animTransformIndex _startTransform;
		private animTransformIndex _middleTransform;
		private animTransformIndex _endTransform;
		private animTransformIndex _constrainedTransform;
		private CEnum<animConstraintWeightMode> _progressMode;
		private CFloat _defaultProgress;
		private animNamedTrackIndex _progressTrack;

		[Ordinal(12)] 
		[RED("areSourceChannelsResaved")] 
		public CBool AreSourceChannelsResaved
		{
			get
			{
				if (_areSourceChannelsResaved == null)
				{
					_areSourceChannelsResaved = (CBool) CR2WTypeManager.Create("Bool", "areSourceChannelsResaved", cr2w, this);
				}
				return _areSourceChannelsResaved;
			}
			set
			{
				if (_areSourceChannelsResaved == value)
				{
					return;
				}
				_areSourceChannelsResaved = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("startTransform")] 
		public animTransformIndex StartTransform
		{
			get
			{
				if (_startTransform == null)
				{
					_startTransform = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "startTransform", cr2w, this);
				}
				return _startTransform;
			}
			set
			{
				if (_startTransform == value)
				{
					return;
				}
				_startTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("middleTransform")] 
		public animTransformIndex MiddleTransform
		{
			get
			{
				if (_middleTransform == null)
				{
					_middleTransform = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "middleTransform", cr2w, this);
				}
				return _middleTransform;
			}
			set
			{
				if (_middleTransform == value)
				{
					return;
				}
				_middleTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("endTransform")] 
		public animTransformIndex EndTransform
		{
			get
			{
				if (_endTransform == null)
				{
					_endTransform = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "endTransform", cr2w, this);
				}
				return _endTransform;
			}
			set
			{
				if (_endTransform == value)
				{
					return;
				}
				_endTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("constrainedTransform")] 
		public animTransformIndex ConstrainedTransform
		{
			get
			{
				if (_constrainedTransform == null)
				{
					_constrainedTransform = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "constrainedTransform", cr2w, this);
				}
				return _constrainedTransform;
			}
			set
			{
				if (_constrainedTransform == value)
				{
					return;
				}
				_constrainedTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("progressMode")] 
		public CEnum<animConstraintWeightMode> ProgressMode
		{
			get
			{
				if (_progressMode == null)
				{
					_progressMode = (CEnum<animConstraintWeightMode>) CR2WTypeManager.Create("animConstraintWeightMode", "progressMode", cr2w, this);
				}
				return _progressMode;
			}
			set
			{
				if (_progressMode == value)
				{
					return;
				}
				_progressMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("defaultProgress")] 
		public CFloat DefaultProgress
		{
			get
			{
				if (_defaultProgress == null)
				{
					_defaultProgress = (CFloat) CR2WTypeManager.Create("Float", "defaultProgress", cr2w, this);
				}
				return _defaultProgress;
			}
			set
			{
				if (_defaultProgress == value)
				{
					return;
				}
				_defaultProgress = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("progressTrack")] 
		public animNamedTrackIndex ProgressTrack
		{
			get
			{
				if (_progressTrack == null)
				{
					_progressTrack = (animNamedTrackIndex) CR2WTypeManager.Create("animNamedTrackIndex", "progressTrack", cr2w, this);
				}
				return _progressTrack;
			}
			set
			{
				if (_progressTrack == value)
				{
					return;
				}
				_progressTrack = value;
				PropertySet(this);
			}
		}

		public animAnimNode_SimpleSpline(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
