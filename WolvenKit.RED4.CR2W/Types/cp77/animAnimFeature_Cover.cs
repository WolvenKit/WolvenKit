using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_Cover : animAnimFeature
	{
		private Vector4 _coverPosition;
		private Vector4 _coverDirection;
		private CInt32 _coverState;
		private CFloat _coverAngleToAction;
		private CInt32 _stance;
		private CInt32 _behavior;
		private CInt32 _coverAction;
		private CFloat _behaviorTime_PreAction;
		private CFloat _behaviorTime_Action;
		private CFloat _behaviorTime_PostAction;

		[Ordinal(0)] 
		[RED("coverPosition")] 
		public Vector4 CoverPosition
		{
			get
			{
				if (_coverPosition == null)
				{
					_coverPosition = (Vector4) CR2WTypeManager.Create("Vector4", "coverPosition", cr2w, this);
				}
				return _coverPosition;
			}
			set
			{
				if (_coverPosition == value)
				{
					return;
				}
				_coverPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("coverDirection")] 
		public Vector4 CoverDirection
		{
			get
			{
				if (_coverDirection == null)
				{
					_coverDirection = (Vector4) CR2WTypeManager.Create("Vector4", "coverDirection", cr2w, this);
				}
				return _coverDirection;
			}
			set
			{
				if (_coverDirection == value)
				{
					return;
				}
				_coverDirection = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("coverState")] 
		public CInt32 CoverState
		{
			get
			{
				if (_coverState == null)
				{
					_coverState = (CInt32) CR2WTypeManager.Create("Int32", "coverState", cr2w, this);
				}
				return _coverState;
			}
			set
			{
				if (_coverState == value)
				{
					return;
				}
				_coverState = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("coverAngleToAction")] 
		public CFloat CoverAngleToAction
		{
			get
			{
				if (_coverAngleToAction == null)
				{
					_coverAngleToAction = (CFloat) CR2WTypeManager.Create("Float", "coverAngleToAction", cr2w, this);
				}
				return _coverAngleToAction;
			}
			set
			{
				if (_coverAngleToAction == value)
				{
					return;
				}
				_coverAngleToAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("stance")] 
		public CInt32 Stance
		{
			get
			{
				if (_stance == null)
				{
					_stance = (CInt32) CR2WTypeManager.Create("Int32", "stance", cr2w, this);
				}
				return _stance;
			}
			set
			{
				if (_stance == value)
				{
					return;
				}
				_stance = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("behavior")] 
		public CInt32 Behavior
		{
			get
			{
				if (_behavior == null)
				{
					_behavior = (CInt32) CR2WTypeManager.Create("Int32", "behavior", cr2w, this);
				}
				return _behavior;
			}
			set
			{
				if (_behavior == value)
				{
					return;
				}
				_behavior = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("coverAction")] 
		public CInt32 CoverAction
		{
			get
			{
				if (_coverAction == null)
				{
					_coverAction = (CInt32) CR2WTypeManager.Create("Int32", "coverAction", cr2w, this);
				}
				return _coverAction;
			}
			set
			{
				if (_coverAction == value)
				{
					return;
				}
				_coverAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("behaviorTime_PreAction")] 
		public CFloat BehaviorTime_PreAction
		{
			get
			{
				if (_behaviorTime_PreAction == null)
				{
					_behaviorTime_PreAction = (CFloat) CR2WTypeManager.Create("Float", "behaviorTime_PreAction", cr2w, this);
				}
				return _behaviorTime_PreAction;
			}
			set
			{
				if (_behaviorTime_PreAction == value)
				{
					return;
				}
				_behaviorTime_PreAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("behaviorTime_Action")] 
		public CFloat BehaviorTime_Action
		{
			get
			{
				if (_behaviorTime_Action == null)
				{
					_behaviorTime_Action = (CFloat) CR2WTypeManager.Create("Float", "behaviorTime_Action", cr2w, this);
				}
				return _behaviorTime_Action;
			}
			set
			{
				if (_behaviorTime_Action == value)
				{
					return;
				}
				_behaviorTime_Action = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("behaviorTime_PostAction")] 
		public CFloat BehaviorTime_PostAction
		{
			get
			{
				if (_behaviorTime_PostAction == null)
				{
					_behaviorTime_PostAction = (CFloat) CR2WTypeManager.Create("Float", "behaviorTime_PostAction", cr2w, this);
				}
				return _behaviorTime_PostAction;
			}
			set
			{
				if (_behaviorTime_PostAction == value)
				{
					return;
				}
				_behaviorTime_PostAction = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_Cover(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
