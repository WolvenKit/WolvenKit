using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_LocomotionAdjusterOnEvent : animAnimNode_LocomotionAdjuster
	{
		private CName _locomotionFeatureName;
		private CName _targetAnimationName;
		private CName _startAdjustmentAfterAnimEvent;

		[Ordinal(19)] 
		[RED("locomotionFeatureName")] 
		public CName LocomotionFeatureName
		{
			get
			{
				if (_locomotionFeatureName == null)
				{
					_locomotionFeatureName = (CName) CR2WTypeManager.Create("CName", "locomotionFeatureName", cr2w, this);
				}
				return _locomotionFeatureName;
			}
			set
			{
				if (_locomotionFeatureName == value)
				{
					return;
				}
				_locomotionFeatureName = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("targetAnimationName")] 
		public CName TargetAnimationName
		{
			get
			{
				if (_targetAnimationName == null)
				{
					_targetAnimationName = (CName) CR2WTypeManager.Create("CName", "targetAnimationName", cr2w, this);
				}
				return _targetAnimationName;
			}
			set
			{
				if (_targetAnimationName == value)
				{
					return;
				}
				_targetAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("startAdjustmentAfterAnimEvent")] 
		public CName StartAdjustmentAfterAnimEvent
		{
			get
			{
				if (_startAdjustmentAfterAnimEvent == null)
				{
					_startAdjustmentAfterAnimEvent = (CName) CR2WTypeManager.Create("CName", "startAdjustmentAfterAnimEvent", cr2w, this);
				}
				return _startAdjustmentAfterAnimEvent;
			}
			set
			{
				if (_startAdjustmentAfterAnimEvent == value)
				{
					return;
				}
				_startAdjustmentAfterAnimEvent = value;
				PropertySet(this);
			}
		}

		public animAnimNode_LocomotionAdjusterOnEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
