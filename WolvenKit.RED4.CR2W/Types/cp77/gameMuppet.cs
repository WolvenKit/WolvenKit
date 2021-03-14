using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppet : gamePuppetBase
	{
		private CHandle<entSlotComponent> _hitRepresantation;
		private CHandle<entSlotComponent> _slotComponent;
		private CFloat _highDamageThreshold;
		private CFloat _medDamageThreshold;
		private CFloat _lowDamageThreshold;
		private CFloat _effectTimeStamp;

		[Ordinal(40)] 
		[RED("hitRepresantation")] 
		public CHandle<entSlotComponent> HitRepresantation
		{
			get
			{
				if (_hitRepresantation == null)
				{
					_hitRepresantation = (CHandle<entSlotComponent>) CR2WTypeManager.Create("handle:entSlotComponent", "hitRepresantation", cr2w, this);
				}
				return _hitRepresantation;
			}
			set
			{
				if (_hitRepresantation == value)
				{
					return;
				}
				_hitRepresantation = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("slotComponent")] 
		public CHandle<entSlotComponent> SlotComponent
		{
			get
			{
				if (_slotComponent == null)
				{
					_slotComponent = (CHandle<entSlotComponent>) CR2WTypeManager.Create("handle:entSlotComponent", "slotComponent", cr2w, this);
				}
				return _slotComponent;
			}
			set
			{
				if (_slotComponent == value)
				{
					return;
				}
				_slotComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("highDamageThreshold")] 
		public CFloat HighDamageThreshold
		{
			get
			{
				if (_highDamageThreshold == null)
				{
					_highDamageThreshold = (CFloat) CR2WTypeManager.Create("Float", "highDamageThreshold", cr2w, this);
				}
				return _highDamageThreshold;
			}
			set
			{
				if (_highDamageThreshold == value)
				{
					return;
				}
				_highDamageThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("medDamageThreshold")] 
		public CFloat MedDamageThreshold
		{
			get
			{
				if (_medDamageThreshold == null)
				{
					_medDamageThreshold = (CFloat) CR2WTypeManager.Create("Float", "medDamageThreshold", cr2w, this);
				}
				return _medDamageThreshold;
			}
			set
			{
				if (_medDamageThreshold == value)
				{
					return;
				}
				_medDamageThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("lowDamageThreshold")] 
		public CFloat LowDamageThreshold
		{
			get
			{
				if (_lowDamageThreshold == null)
				{
					_lowDamageThreshold = (CFloat) CR2WTypeManager.Create("Float", "lowDamageThreshold", cr2w, this);
				}
				return _lowDamageThreshold;
			}
			set
			{
				if (_lowDamageThreshold == value)
				{
					return;
				}
				_lowDamageThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("effectTimeStamp")] 
		public CFloat EffectTimeStamp
		{
			get
			{
				if (_effectTimeStamp == null)
				{
					_effectTimeStamp = (CFloat) CR2WTypeManager.Create("Float", "effectTimeStamp", cr2w, this);
				}
				return _effectTimeStamp;
			}
			set
			{
				if (_effectTimeStamp == value)
				{
					return;
				}
				_effectTimeStamp = value;
				PropertySet(this);
			}
		}

		public gameMuppet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
