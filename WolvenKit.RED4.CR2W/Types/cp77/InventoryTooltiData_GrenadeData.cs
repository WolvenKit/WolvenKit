using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryTooltiData_GrenadeData : IScriptable
	{
		private CEnum<GrenadeDamageType> _type;
		private CFloat _range;
		private CFloat _duration;
		private CFloat _delay;
		private CFloat _damagePerTick;
		private CEnum<gamedataStatType> _damageType;
		private CFloat _detonationTimer;
		private CEnum<gamedataGrenadeDeliveryMethodType> _deliveryMethod;
		private CFloat _totalDamage;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<GrenadeDamageType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<GrenadeDamageType>) CR2WTypeManager.Create("GrenadeDamageType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("range")] 
		public CFloat Range
		{
			get
			{
				if (_range == null)
				{
					_range = (CFloat) CR2WTypeManager.Create("Float", "range", cr2w, this);
				}
				return _range;
			}
			set
			{
				if (_range == value)
				{
					return;
				}
				_range = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get
			{
				if (_delay == null)
				{
					_delay = (CFloat) CR2WTypeManager.Create("Float", "delay", cr2w, this);
				}
				return _delay;
			}
			set
			{
				if (_delay == value)
				{
					return;
				}
				_delay = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("damagePerTick")] 
		public CFloat DamagePerTick
		{
			get
			{
				if (_damagePerTick == null)
				{
					_damagePerTick = (CFloat) CR2WTypeManager.Create("Float", "damagePerTick", cr2w, this);
				}
				return _damagePerTick;
			}
			set
			{
				if (_damagePerTick == value)
				{
					return;
				}
				_damagePerTick = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("damageType")] 
		public CEnum<gamedataStatType> DamageType
		{
			get
			{
				if (_damageType == null)
				{
					_damageType = (CEnum<gamedataStatType>) CR2WTypeManager.Create("gamedataStatType", "damageType", cr2w, this);
				}
				return _damageType;
			}
			set
			{
				if (_damageType == value)
				{
					return;
				}
				_damageType = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("detonationTimer")] 
		public CFloat DetonationTimer
		{
			get
			{
				if (_detonationTimer == null)
				{
					_detonationTimer = (CFloat) CR2WTypeManager.Create("Float", "detonationTimer", cr2w, this);
				}
				return _detonationTimer;
			}
			set
			{
				if (_detonationTimer == value)
				{
					return;
				}
				_detonationTimer = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("deliveryMethod")] 
		public CEnum<gamedataGrenadeDeliveryMethodType> DeliveryMethod
		{
			get
			{
				if (_deliveryMethod == null)
				{
					_deliveryMethod = (CEnum<gamedataGrenadeDeliveryMethodType>) CR2WTypeManager.Create("gamedataGrenadeDeliveryMethodType", "deliveryMethod", cr2w, this);
				}
				return _deliveryMethod;
			}
			set
			{
				if (_deliveryMethod == value)
				{
					return;
				}
				_deliveryMethod = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("totalDamage")] 
		public CFloat TotalDamage
		{
			get
			{
				if (_totalDamage == null)
				{
					_totalDamage = (CFloat) CR2WTypeManager.Create("Float", "totalDamage", cr2w, this);
				}
				return _totalDamage;
			}
			set
			{
				if (_totalDamage == value)
				{
					return;
				}
				_totalDamage = value;
				PropertySet(this);
			}
		}

		public InventoryTooltiData_GrenadeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
