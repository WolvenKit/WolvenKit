using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_MotionAdjuster : animAnimNode_Base
	{
		private animPoseLink _inputNode;
		private animVectorLink _targetPosition;
		private animVectorLink _targetDirection;
		private animFloatLink _totalTimeToAdjust;
		private Vector4 _forwardVector;

		[Ordinal(11)] 
		[RED("inputNode")] 
		public animPoseLink InputNode
		{
			get
			{
				if (_inputNode == null)
				{
					_inputNode = (animPoseLink) CR2WTypeManager.Create("animPoseLink", "inputNode", cr2w, this);
				}
				return _inputNode;
			}
			set
			{
				if (_inputNode == value)
				{
					return;
				}
				_inputNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("targetPosition")] 
		public animVectorLink TargetPosition
		{
			get
			{
				if (_targetPosition == null)
				{
					_targetPosition = (animVectorLink) CR2WTypeManager.Create("animVectorLink", "targetPosition", cr2w, this);
				}
				return _targetPosition;
			}
			set
			{
				if (_targetPosition == value)
				{
					return;
				}
				_targetPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("targetDirection")] 
		public animVectorLink TargetDirection
		{
			get
			{
				if (_targetDirection == null)
				{
					_targetDirection = (animVectorLink) CR2WTypeManager.Create("animVectorLink", "targetDirection", cr2w, this);
				}
				return _targetDirection;
			}
			set
			{
				if (_targetDirection == value)
				{
					return;
				}
				_targetDirection = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("totalTimeToAdjust")] 
		public animFloatLink TotalTimeToAdjust
		{
			get
			{
				if (_totalTimeToAdjust == null)
				{
					_totalTimeToAdjust = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "totalTimeToAdjust", cr2w, this);
				}
				return _totalTimeToAdjust;
			}
			set
			{
				if (_totalTimeToAdjust == value)
				{
					return;
				}
				_totalTimeToAdjust = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("forwardVector")] 
		public Vector4 ForwardVector
		{
			get
			{
				if (_forwardVector == null)
				{
					_forwardVector = (Vector4) CR2WTypeManager.Create("Vector4", "forwardVector", cr2w, this);
				}
				return _forwardVector;
			}
			set
			{
				if (_forwardVector == value)
				{
					return;
				}
				_forwardVector = value;
				PropertySet(this);
			}
		}

		public animAnimNode_MotionAdjuster(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
