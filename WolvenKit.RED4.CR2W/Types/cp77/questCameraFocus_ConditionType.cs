using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCameraFocus_ConditionType : questISystemConditionType
	{
		private gameEntityReference _objectRef;
		private CFloat _timeInterval;
		private CBool _onScreenTest;
		private CBool _useFrustrumCheck;
		private CFloat _angleTolerance;
		private CBool _inverted;
		private CBool _zoomed;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get
			{
				if (_objectRef == null)
				{
					_objectRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "objectRef", cr2w, this);
				}
				return _objectRef;
			}
			set
			{
				if (_objectRef == value)
				{
					return;
				}
				_objectRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("timeInterval")] 
		public CFloat TimeInterval
		{
			get
			{
				if (_timeInterval == null)
				{
					_timeInterval = (CFloat) CR2WTypeManager.Create("Float", "timeInterval", cr2w, this);
				}
				return _timeInterval;
			}
			set
			{
				if (_timeInterval == value)
				{
					return;
				}
				_timeInterval = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("onScreenTest")] 
		public CBool OnScreenTest
		{
			get
			{
				if (_onScreenTest == null)
				{
					_onScreenTest = (CBool) CR2WTypeManager.Create("Bool", "onScreenTest", cr2w, this);
				}
				return _onScreenTest;
			}
			set
			{
				if (_onScreenTest == value)
				{
					return;
				}
				_onScreenTest = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("useFrustrumCheck")] 
		public CBool UseFrustrumCheck
		{
			get
			{
				if (_useFrustrumCheck == null)
				{
					_useFrustrumCheck = (CBool) CR2WTypeManager.Create("Bool", "useFrustrumCheck", cr2w, this);
				}
				return _useFrustrumCheck;
			}
			set
			{
				if (_useFrustrumCheck == value)
				{
					return;
				}
				_useFrustrumCheck = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("angleTolerance")] 
		public CFloat AngleTolerance
		{
			get
			{
				if (_angleTolerance == null)
				{
					_angleTolerance = (CFloat) CR2WTypeManager.Create("Float", "angleTolerance", cr2w, this);
				}
				return _angleTolerance;
			}
			set
			{
				if (_angleTolerance == value)
				{
					return;
				}
				_angleTolerance = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get
			{
				if (_inverted == null)
				{
					_inverted = (CBool) CR2WTypeManager.Create("Bool", "inverted", cr2w, this);
				}
				return _inverted;
			}
			set
			{
				if (_inverted == value)
				{
					return;
				}
				_inverted = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("zoomed")] 
		public CBool Zoomed
		{
			get
			{
				if (_zoomed == null)
				{
					_zoomed = (CBool) CR2WTypeManager.Create("Bool", "zoomed", cr2w, this);
				}
				return _zoomed;
			}
			set
			{
				if (_zoomed == value)
				{
					return;
				}
				_zoomed = value;
				PropertySet(this);
			}
		}

		public questCameraFocus_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
