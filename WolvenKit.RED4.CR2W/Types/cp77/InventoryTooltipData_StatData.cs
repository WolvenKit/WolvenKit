using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryTooltipData_StatData : CVariable
	{
		private CEnum<gamedataStatType> _statType;
		private CString _statName;
		private CInt32 _minStatValue;
		private CInt32 _maxStatValue;
		private CInt32 _currentValue;
		private CInt32 _diffValue;
		private CFloat _minStatValueF;
		private CFloat _maxStatValueF;
		private CFloat _currentValueF;
		private CFloat _diffValueF;
		private CEnum<EInventoryDataStatDisplayType> _state;

		[Ordinal(0)] 
		[RED("statType")] 
		public CEnum<gamedataStatType> StatType
		{
			get
			{
				if (_statType == null)
				{
					_statType = (CEnum<gamedataStatType>) CR2WTypeManager.Create("gamedataStatType", "statType", cr2w, this);
				}
				return _statType;
			}
			set
			{
				if (_statType == value)
				{
					return;
				}
				_statType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("statName")] 
		public CString StatName
		{
			get
			{
				if (_statName == null)
				{
					_statName = (CString) CR2WTypeManager.Create("String", "statName", cr2w, this);
				}
				return _statName;
			}
			set
			{
				if (_statName == value)
				{
					return;
				}
				_statName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("minStatValue")] 
		public CInt32 MinStatValue
		{
			get
			{
				if (_minStatValue == null)
				{
					_minStatValue = (CInt32) CR2WTypeManager.Create("Int32", "minStatValue", cr2w, this);
				}
				return _minStatValue;
			}
			set
			{
				if (_minStatValue == value)
				{
					return;
				}
				_minStatValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("maxStatValue")] 
		public CInt32 MaxStatValue
		{
			get
			{
				if (_maxStatValue == null)
				{
					_maxStatValue = (CInt32) CR2WTypeManager.Create("Int32", "maxStatValue", cr2w, this);
				}
				return _maxStatValue;
			}
			set
			{
				if (_maxStatValue == value)
				{
					return;
				}
				_maxStatValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("currentValue")] 
		public CInt32 CurrentValue
		{
			get
			{
				if (_currentValue == null)
				{
					_currentValue = (CInt32) CR2WTypeManager.Create("Int32", "currentValue", cr2w, this);
				}
				return _currentValue;
			}
			set
			{
				if (_currentValue == value)
				{
					return;
				}
				_currentValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("diffValue")] 
		public CInt32 DiffValue
		{
			get
			{
				if (_diffValue == null)
				{
					_diffValue = (CInt32) CR2WTypeManager.Create("Int32", "diffValue", cr2w, this);
				}
				return _diffValue;
			}
			set
			{
				if (_diffValue == value)
				{
					return;
				}
				_diffValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("minStatValueF")] 
		public CFloat MinStatValueF
		{
			get
			{
				if (_minStatValueF == null)
				{
					_minStatValueF = (CFloat) CR2WTypeManager.Create("Float", "minStatValueF", cr2w, this);
				}
				return _minStatValueF;
			}
			set
			{
				if (_minStatValueF == value)
				{
					return;
				}
				_minStatValueF = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("maxStatValueF")] 
		public CFloat MaxStatValueF
		{
			get
			{
				if (_maxStatValueF == null)
				{
					_maxStatValueF = (CFloat) CR2WTypeManager.Create("Float", "maxStatValueF", cr2w, this);
				}
				return _maxStatValueF;
			}
			set
			{
				if (_maxStatValueF == value)
				{
					return;
				}
				_maxStatValueF = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("currentValueF")] 
		public CFloat CurrentValueF
		{
			get
			{
				if (_currentValueF == null)
				{
					_currentValueF = (CFloat) CR2WTypeManager.Create("Float", "currentValueF", cr2w, this);
				}
				return _currentValueF;
			}
			set
			{
				if (_currentValueF == value)
				{
					return;
				}
				_currentValueF = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("diffValueF")] 
		public CFloat DiffValueF
		{
			get
			{
				if (_diffValueF == null)
				{
					_diffValueF = (CFloat) CR2WTypeManager.Create("Float", "diffValueF", cr2w, this);
				}
				return _diffValueF;
			}
			set
			{
				if (_diffValueF == value)
				{
					return;
				}
				_diffValueF = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("state")] 
		public CEnum<EInventoryDataStatDisplayType> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<EInventoryDataStatDisplayType>) CR2WTypeManager.Create("EInventoryDataStatDisplayType", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		public InventoryTooltipData_StatData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
