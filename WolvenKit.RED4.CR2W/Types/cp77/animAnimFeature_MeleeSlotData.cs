using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_MeleeSlotData : animAnimFeature
	{
		private CInt32 _attackType;
		private CInt32 _comboNumber;
		private CFloat _startupDuration;
		private CFloat _activeDuration;
		private CFloat _recoverDuration;
		private CFloat _activeHitDuration;
		private CFloat _recoverHitDuration;

		[Ordinal(0)] 
		[RED("attackType")] 
		public CInt32 AttackType
		{
			get
			{
				if (_attackType == null)
				{
					_attackType = (CInt32) CR2WTypeManager.Create("Int32", "attackType", cr2w, this);
				}
				return _attackType;
			}
			set
			{
				if (_attackType == value)
				{
					return;
				}
				_attackType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("comboNumber")] 
		public CInt32 ComboNumber
		{
			get
			{
				if (_comboNumber == null)
				{
					_comboNumber = (CInt32) CR2WTypeManager.Create("Int32", "comboNumber", cr2w, this);
				}
				return _comboNumber;
			}
			set
			{
				if (_comboNumber == value)
				{
					return;
				}
				_comboNumber = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("startupDuration")] 
		public CFloat StartupDuration
		{
			get
			{
				if (_startupDuration == null)
				{
					_startupDuration = (CFloat) CR2WTypeManager.Create("Float", "startupDuration", cr2w, this);
				}
				return _startupDuration;
			}
			set
			{
				if (_startupDuration == value)
				{
					return;
				}
				_startupDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("activeDuration")] 
		public CFloat ActiveDuration
		{
			get
			{
				if (_activeDuration == null)
				{
					_activeDuration = (CFloat) CR2WTypeManager.Create("Float", "activeDuration", cr2w, this);
				}
				return _activeDuration;
			}
			set
			{
				if (_activeDuration == value)
				{
					return;
				}
				_activeDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("recoverDuration")] 
		public CFloat RecoverDuration
		{
			get
			{
				if (_recoverDuration == null)
				{
					_recoverDuration = (CFloat) CR2WTypeManager.Create("Float", "recoverDuration", cr2w, this);
				}
				return _recoverDuration;
			}
			set
			{
				if (_recoverDuration == value)
				{
					return;
				}
				_recoverDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("activeHitDuration")] 
		public CFloat ActiveHitDuration
		{
			get
			{
				if (_activeHitDuration == null)
				{
					_activeHitDuration = (CFloat) CR2WTypeManager.Create("Float", "activeHitDuration", cr2w, this);
				}
				return _activeHitDuration;
			}
			set
			{
				if (_activeHitDuration == value)
				{
					return;
				}
				_activeHitDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("recoverHitDuration")] 
		public CFloat RecoverHitDuration
		{
			get
			{
				if (_recoverHitDuration == null)
				{
					_recoverHitDuration = (CFloat) CR2WTypeManager.Create("Float", "recoverHitDuration", cr2w, this);
				}
				return _recoverHitDuration;
			}
			set
			{
				if (_recoverHitDuration == value)
				{
					return;
				}
				_recoverHitDuration = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_MeleeSlotData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
