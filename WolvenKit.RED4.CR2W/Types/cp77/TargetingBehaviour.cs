using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TargetingBehaviour : CVariable
	{
		private CEnum<ESensorDeviceWakeState> _initialWakeState;
		private CBool _canRotate;
		private CFloat _lostTargetLookAtTime;
		private CFloat _lostTargetSearchTime;

		[Ordinal(0)] 
		[RED("initialWakeState")] 
		public CEnum<ESensorDeviceWakeState> InitialWakeState
		{
			get
			{
				if (_initialWakeState == null)
				{
					_initialWakeState = (CEnum<ESensorDeviceWakeState>) CR2WTypeManager.Create("ESensorDeviceWakeState", "initialWakeState", cr2w, this);
				}
				return _initialWakeState;
			}
			set
			{
				if (_initialWakeState == value)
				{
					return;
				}
				_initialWakeState = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("canRotate")] 
		public CBool CanRotate
		{
			get
			{
				if (_canRotate == null)
				{
					_canRotate = (CBool) CR2WTypeManager.Create("Bool", "canRotate", cr2w, this);
				}
				return _canRotate;
			}
			set
			{
				if (_canRotate == value)
				{
					return;
				}
				_canRotate = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("lostTargetLookAtTime")] 
		public CFloat LostTargetLookAtTime
		{
			get
			{
				if (_lostTargetLookAtTime == null)
				{
					_lostTargetLookAtTime = (CFloat) CR2WTypeManager.Create("Float", "lostTargetLookAtTime", cr2w, this);
				}
				return _lostTargetLookAtTime;
			}
			set
			{
				if (_lostTargetLookAtTime == value)
				{
					return;
				}
				_lostTargetLookAtTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("lostTargetSearchTime")] 
		public CFloat LostTargetSearchTime
		{
			get
			{
				if (_lostTargetSearchTime == null)
				{
					_lostTargetSearchTime = (CFloat) CR2WTypeManager.Create("Float", "lostTargetSearchTime", cr2w, this);
				}
				return _lostTargetSearchTime;
			}
			set
			{
				if (_lostTargetSearchTime == value)
				{
					return;
				}
				_lostTargetSearchTime = value;
				PropertySet(this);
			}
		}

		public TargetingBehaviour(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
