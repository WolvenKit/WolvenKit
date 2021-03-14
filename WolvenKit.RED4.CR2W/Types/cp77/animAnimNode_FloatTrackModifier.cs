using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatTrackModifier : animAnimNode_Base
	{
		private animNamedTrackIndex _floatTrack;
		private CEnum<animFloatTrackOperationType> _operationType;
		private animNamedTrackIndex _inputFloatTrack;
		private animPoseLink _poseInputNode;
		private animFloatLink _floatInputNode;

		[Ordinal(11)] 
		[RED("floatTrack")] 
		public animNamedTrackIndex FloatTrack
		{
			get
			{
				if (_floatTrack == null)
				{
					_floatTrack = (animNamedTrackIndex) CR2WTypeManager.Create("animNamedTrackIndex", "floatTrack", cr2w, this);
				}
				return _floatTrack;
			}
			set
			{
				if (_floatTrack == value)
				{
					return;
				}
				_floatTrack = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("operationType")] 
		public CEnum<animFloatTrackOperationType> OperationType
		{
			get
			{
				if (_operationType == null)
				{
					_operationType = (CEnum<animFloatTrackOperationType>) CR2WTypeManager.Create("animFloatTrackOperationType", "operationType", cr2w, this);
				}
				return _operationType;
			}
			set
			{
				if (_operationType == value)
				{
					return;
				}
				_operationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("inputFloatTrack")] 
		public animNamedTrackIndex InputFloatTrack
		{
			get
			{
				if (_inputFloatTrack == null)
				{
					_inputFloatTrack = (animNamedTrackIndex) CR2WTypeManager.Create("animNamedTrackIndex", "inputFloatTrack", cr2w, this);
				}
				return _inputFloatTrack;
			}
			set
			{
				if (_inputFloatTrack == value)
				{
					return;
				}
				_inputFloatTrack = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("poseInputNode")] 
		public animPoseLink PoseInputNode
		{
			get
			{
				if (_poseInputNode == null)
				{
					_poseInputNode = (animPoseLink) CR2WTypeManager.Create("animPoseLink", "poseInputNode", cr2w, this);
				}
				return _poseInputNode;
			}
			set
			{
				if (_poseInputNode == value)
				{
					return;
				}
				_poseInputNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("floatInputNode")] 
		public animFloatLink FloatInputNode
		{
			get
			{
				if (_floatInputNode == null)
				{
					_floatInputNode = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "floatInputNode", cr2w, this);
				}
				return _floatInputNode;
			}
			set
			{
				if (_floatInputNode == value)
				{
					return;
				}
				_floatInputNode = value;
				PropertySet(this);
			}
		}

		public animAnimNode_FloatTrackModifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
