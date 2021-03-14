using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameweaponAnimFeature_WeaponData : animAnimFeature
	{
		private CFloat _cycleTime;
		private CFloat _chargePercentage;
		private CFloat _timeInMaxCharge;
		private CInt32 _ammoRemaining;
		private CInt32 _triggerMode;
		private CBool _isMagazineFull;
		private CBool _isTriggerDown;

		[Ordinal(0)] 
		[RED("cycleTime")] 
		public CFloat CycleTime
		{
			get
			{
				if (_cycleTime == null)
				{
					_cycleTime = (CFloat) CR2WTypeManager.Create("Float", "cycleTime", cr2w, this);
				}
				return _cycleTime;
			}
			set
			{
				if (_cycleTime == value)
				{
					return;
				}
				_cycleTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("chargePercentage")] 
		public CFloat ChargePercentage
		{
			get
			{
				if (_chargePercentage == null)
				{
					_chargePercentage = (CFloat) CR2WTypeManager.Create("Float", "chargePercentage", cr2w, this);
				}
				return _chargePercentage;
			}
			set
			{
				if (_chargePercentage == value)
				{
					return;
				}
				_chargePercentage = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("timeInMaxCharge")] 
		public CFloat TimeInMaxCharge
		{
			get
			{
				if (_timeInMaxCharge == null)
				{
					_timeInMaxCharge = (CFloat) CR2WTypeManager.Create("Float", "timeInMaxCharge", cr2w, this);
				}
				return _timeInMaxCharge;
			}
			set
			{
				if (_timeInMaxCharge == value)
				{
					return;
				}
				_timeInMaxCharge = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("ammoRemaining")] 
		public CInt32 AmmoRemaining
		{
			get
			{
				if (_ammoRemaining == null)
				{
					_ammoRemaining = (CInt32) CR2WTypeManager.Create("Int32", "ammoRemaining", cr2w, this);
				}
				return _ammoRemaining;
			}
			set
			{
				if (_ammoRemaining == value)
				{
					return;
				}
				_ammoRemaining = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("triggerMode")] 
		public CInt32 TriggerMode
		{
			get
			{
				if (_triggerMode == null)
				{
					_triggerMode = (CInt32) CR2WTypeManager.Create("Int32", "triggerMode", cr2w, this);
				}
				return _triggerMode;
			}
			set
			{
				if (_triggerMode == value)
				{
					return;
				}
				_triggerMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isMagazineFull")] 
		public CBool IsMagazineFull
		{
			get
			{
				if (_isMagazineFull == null)
				{
					_isMagazineFull = (CBool) CR2WTypeManager.Create("Bool", "isMagazineFull", cr2w, this);
				}
				return _isMagazineFull;
			}
			set
			{
				if (_isMagazineFull == value)
				{
					return;
				}
				_isMagazineFull = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isTriggerDown")] 
		public CBool IsTriggerDown
		{
			get
			{
				if (_isTriggerDown == null)
				{
					_isTriggerDown = (CBool) CR2WTypeManager.Create("Bool", "isTriggerDown", cr2w, this);
				}
				return _isTriggerDown;
			}
			set
			{
				if (_isTriggerDown == value)
				{
					return;
				}
				_isTriggerDown = value;
				PropertySet(this);
			}
		}

		public gameweaponAnimFeature_WeaponData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
