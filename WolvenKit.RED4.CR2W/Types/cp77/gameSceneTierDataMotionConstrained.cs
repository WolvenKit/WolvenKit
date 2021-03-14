using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSceneTierDataMotionConstrained : gameSceneTierData
	{
		private NodeRef _splineRef;
		private CFloat _adjustingSpeed;
		private CFloat _adjustingDuration;
		private CFloat _travellingSpeed;
		private CFloat _travellingDuration;
		private CInt32 _notificationBackwardIndex;

		[Ordinal(2)] 
		[RED("splineRef")] 
		public NodeRef SplineRef
		{
			get
			{
				if (_splineRef == null)
				{
					_splineRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "splineRef", cr2w, this);
				}
				return _splineRef;
			}
			set
			{
				if (_splineRef == value)
				{
					return;
				}
				_splineRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("adjustingSpeed")] 
		public CFloat AdjustingSpeed
		{
			get
			{
				if (_adjustingSpeed == null)
				{
					_adjustingSpeed = (CFloat) CR2WTypeManager.Create("Float", "adjustingSpeed", cr2w, this);
				}
				return _adjustingSpeed;
			}
			set
			{
				if (_adjustingSpeed == value)
				{
					return;
				}
				_adjustingSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("adjustingDuration")] 
		public CFloat AdjustingDuration
		{
			get
			{
				if (_adjustingDuration == null)
				{
					_adjustingDuration = (CFloat) CR2WTypeManager.Create("Float", "adjustingDuration", cr2w, this);
				}
				return _adjustingDuration;
			}
			set
			{
				if (_adjustingDuration == value)
				{
					return;
				}
				_adjustingDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("travellingSpeed")] 
		public CFloat TravellingSpeed
		{
			get
			{
				if (_travellingSpeed == null)
				{
					_travellingSpeed = (CFloat) CR2WTypeManager.Create("Float", "travellingSpeed", cr2w, this);
				}
				return _travellingSpeed;
			}
			set
			{
				if (_travellingSpeed == value)
				{
					return;
				}
				_travellingSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("travellingDuration")] 
		public CFloat TravellingDuration
		{
			get
			{
				if (_travellingDuration == null)
				{
					_travellingDuration = (CFloat) CR2WTypeManager.Create("Float", "travellingDuration", cr2w, this);
				}
				return _travellingDuration;
			}
			set
			{
				if (_travellingDuration == value)
				{
					return;
				}
				_travellingDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("notificationBackwardIndex")] 
		public CInt32 NotificationBackwardIndex
		{
			get
			{
				if (_notificationBackwardIndex == null)
				{
					_notificationBackwardIndex = (CInt32) CR2WTypeManager.Create("Int32", "notificationBackwardIndex", cr2w, this);
				}
				return _notificationBackwardIndex;
			}
			set
			{
				if (_notificationBackwardIndex == value)
				{
					return;
				}
				_notificationBackwardIndex = value;
				PropertySet(this);
			}
		}

		public gameSceneTierDataMotionConstrained(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
