using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIFollowerInterpolateFollowingSpeed : AIbehaviortaskScript
	{
		private TweakDBID _enterCondition;
		private TweakDBID _exitCondition;
		private CFloat _minInterpolationDistanceToDestination;
		private CFloat _maxInterpolationDistanceToDestination;
		private CFloat _maxTimeDilation;
		private wCHandle<gamedataAIActionCondition_Record> _enterConditionInstance;
		private wCHandle<gamedataAIActionCondition_Record> _exitConditionInstace;
		private CBool _isActive;
		private CName _reason;

		[Ordinal(0)] 
		[RED("enterCondition")] 
		public TweakDBID EnterCondition
		{
			get
			{
				if (_enterCondition == null)
				{
					_enterCondition = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "enterCondition", cr2w, this);
				}
				return _enterCondition;
			}
			set
			{
				if (_enterCondition == value)
				{
					return;
				}
				_enterCondition = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("exitCondition")] 
		public TweakDBID ExitCondition
		{
			get
			{
				if (_exitCondition == null)
				{
					_exitCondition = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "exitCondition", cr2w, this);
				}
				return _exitCondition;
			}
			set
			{
				if (_exitCondition == value)
				{
					return;
				}
				_exitCondition = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("minInterpolationDistanceToDestination")] 
		public CFloat MinInterpolationDistanceToDestination
		{
			get
			{
				if (_minInterpolationDistanceToDestination == null)
				{
					_minInterpolationDistanceToDestination = (CFloat) CR2WTypeManager.Create("Float", "minInterpolationDistanceToDestination", cr2w, this);
				}
				return _minInterpolationDistanceToDestination;
			}
			set
			{
				if (_minInterpolationDistanceToDestination == value)
				{
					return;
				}
				_minInterpolationDistanceToDestination = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("maxInterpolationDistanceToDestination")] 
		public CFloat MaxInterpolationDistanceToDestination
		{
			get
			{
				if (_maxInterpolationDistanceToDestination == null)
				{
					_maxInterpolationDistanceToDestination = (CFloat) CR2WTypeManager.Create("Float", "maxInterpolationDistanceToDestination", cr2w, this);
				}
				return _maxInterpolationDistanceToDestination;
			}
			set
			{
				if (_maxInterpolationDistanceToDestination == value)
				{
					return;
				}
				_maxInterpolationDistanceToDestination = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("maxTimeDilation")] 
		public CFloat MaxTimeDilation
		{
			get
			{
				if (_maxTimeDilation == null)
				{
					_maxTimeDilation = (CFloat) CR2WTypeManager.Create("Float", "maxTimeDilation", cr2w, this);
				}
				return _maxTimeDilation;
			}
			set
			{
				if (_maxTimeDilation == value)
				{
					return;
				}
				_maxTimeDilation = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("enterConditionInstance")] 
		public wCHandle<gamedataAIActionCondition_Record> EnterConditionInstance
		{
			get
			{
				if (_enterConditionInstance == null)
				{
					_enterConditionInstance = (wCHandle<gamedataAIActionCondition_Record>) CR2WTypeManager.Create("whandle:gamedataAIActionCondition_Record", "enterConditionInstance", cr2w, this);
				}
				return _enterConditionInstance;
			}
			set
			{
				if (_enterConditionInstance == value)
				{
					return;
				}
				_enterConditionInstance = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("exitConditionInstace")] 
		public wCHandle<gamedataAIActionCondition_Record> ExitConditionInstace
		{
			get
			{
				if (_exitConditionInstace == null)
				{
					_exitConditionInstace = (wCHandle<gamedataAIActionCondition_Record>) CR2WTypeManager.Create("whandle:gamedataAIActionCondition_Record", "exitConditionInstace", cr2w, this);
				}
				return _exitConditionInstace;
			}
			set
			{
				if (_exitConditionInstace == value)
				{
					return;
				}
				_exitConditionInstace = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get
			{
				if (_isActive == null)
				{
					_isActive = (CBool) CR2WTypeManager.Create("Bool", "isActive", cr2w, this);
				}
				return _isActive;
			}
			set
			{
				if (_isActive == value)
				{
					return;
				}
				_isActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("reason")] 
		public CName Reason
		{
			get
			{
				if (_reason == null)
				{
					_reason = (CName) CR2WTypeManager.Create("CName", "reason", cr2w, this);
				}
				return _reason;
			}
			set
			{
				if (_reason == value)
				{
					return;
				}
				_reason = value;
				PropertySet(this);
			}
		}

		public AIFollowerInterpolateFollowingSpeed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
