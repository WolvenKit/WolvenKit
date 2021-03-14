using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_ExplorationAdjuster : animAnimNode_MotionAdjuster
	{
		private animVectorLink _targetPosition2;
		private animVectorLink _targetDirection2;
		private animFloatLink _totalTimeToAdjust2;
		private animVectorLink _targetPosition3;
		private animVectorLink _targetDirection3;
		private animFloatLink _totalTimeToAdjust3;

		[Ordinal(16)] 
		[RED("targetPosition2")] 
		public animVectorLink TargetPosition2
		{
			get
			{
				if (_targetPosition2 == null)
				{
					_targetPosition2 = (animVectorLink) CR2WTypeManager.Create("animVectorLink", "targetPosition2", cr2w, this);
				}
				return _targetPosition2;
			}
			set
			{
				if (_targetPosition2 == value)
				{
					return;
				}
				_targetPosition2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("targetDirection2")] 
		public animVectorLink TargetDirection2
		{
			get
			{
				if (_targetDirection2 == null)
				{
					_targetDirection2 = (animVectorLink) CR2WTypeManager.Create("animVectorLink", "targetDirection2", cr2w, this);
				}
				return _targetDirection2;
			}
			set
			{
				if (_targetDirection2 == value)
				{
					return;
				}
				_targetDirection2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("totalTimeToAdjust2")] 
		public animFloatLink TotalTimeToAdjust2
		{
			get
			{
				if (_totalTimeToAdjust2 == null)
				{
					_totalTimeToAdjust2 = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "totalTimeToAdjust2", cr2w, this);
				}
				return _totalTimeToAdjust2;
			}
			set
			{
				if (_totalTimeToAdjust2 == value)
				{
					return;
				}
				_totalTimeToAdjust2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("targetPosition3")] 
		public animVectorLink TargetPosition3
		{
			get
			{
				if (_targetPosition3 == null)
				{
					_targetPosition3 = (animVectorLink) CR2WTypeManager.Create("animVectorLink", "targetPosition3", cr2w, this);
				}
				return _targetPosition3;
			}
			set
			{
				if (_targetPosition3 == value)
				{
					return;
				}
				_targetPosition3 = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("targetDirection3")] 
		public animVectorLink TargetDirection3
		{
			get
			{
				if (_targetDirection3 == null)
				{
					_targetDirection3 = (animVectorLink) CR2WTypeManager.Create("animVectorLink", "targetDirection3", cr2w, this);
				}
				return _targetDirection3;
			}
			set
			{
				if (_targetDirection3 == value)
				{
					return;
				}
				_targetDirection3 = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("totalTimeToAdjust3")] 
		public animFloatLink TotalTimeToAdjust3
		{
			get
			{
				if (_totalTimeToAdjust3 == null)
				{
					_totalTimeToAdjust3 = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "totalTimeToAdjust3", cr2w, this);
				}
				return _totalTimeToAdjust3;
			}
			set
			{
				if (_totalTimeToAdjust3 == value)
				{
					return;
				}
				_totalTimeToAdjust3 = value;
				PropertySet(this);
			}
		}

		public animAnimNode_ExplorationAdjuster(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
