using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStatViewData : CVariable
	{
		private CEnum<gamedataStatType> _type;
		private CString _statName;
		private CInt32 _value;
		private CInt32 _diffValue;
		private CBool _isMaxValue;
		private CFloat _valueF;
		private CFloat _diffValueF;
		private CFloat _statMinValueF;
		private CFloat _statMaxValueF;
		private CBool _canBeCompared;
		private CBool _isCompared;
		private CInt32 _statMinValue;
		private CInt32 _statMaxValue;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gamedataStatType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<gamedataStatType>) CR2WTypeManager.Create("gamedataStatType", "type", cr2w, this);
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
		[RED("value")] 
		public CInt32 Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CInt32) CR2WTypeManager.Create("Int32", "value", cr2w, this);
				}
				return _value;
			}
			set
			{
				if (_value == value)
				{
					return;
				}
				_value = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("isMaxValue")] 
		public CBool IsMaxValue
		{
			get
			{
				if (_isMaxValue == null)
				{
					_isMaxValue = (CBool) CR2WTypeManager.Create("Bool", "isMaxValue", cr2w, this);
				}
				return _isMaxValue;
			}
			set
			{
				if (_isMaxValue == value)
				{
					return;
				}
				_isMaxValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("valueF")] 
		public CFloat ValueF
		{
			get
			{
				if (_valueF == null)
				{
					_valueF = (CFloat) CR2WTypeManager.Create("Float", "valueF", cr2w, this);
				}
				return _valueF;
			}
			set
			{
				if (_valueF == value)
				{
					return;
				}
				_valueF = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
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

		[Ordinal(7)] 
		[RED("statMinValueF")] 
		public CFloat StatMinValueF
		{
			get
			{
				if (_statMinValueF == null)
				{
					_statMinValueF = (CFloat) CR2WTypeManager.Create("Float", "statMinValueF", cr2w, this);
				}
				return _statMinValueF;
			}
			set
			{
				if (_statMinValueF == value)
				{
					return;
				}
				_statMinValueF = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("statMaxValueF")] 
		public CFloat StatMaxValueF
		{
			get
			{
				if (_statMaxValueF == null)
				{
					_statMaxValueF = (CFloat) CR2WTypeManager.Create("Float", "statMaxValueF", cr2w, this);
				}
				return _statMaxValueF;
			}
			set
			{
				if (_statMaxValueF == value)
				{
					return;
				}
				_statMaxValueF = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("canBeCompared")] 
		public CBool CanBeCompared
		{
			get
			{
				if (_canBeCompared == null)
				{
					_canBeCompared = (CBool) CR2WTypeManager.Create("Bool", "canBeCompared", cr2w, this);
				}
				return _canBeCompared;
			}
			set
			{
				if (_canBeCompared == value)
				{
					return;
				}
				_canBeCompared = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("isCompared")] 
		public CBool IsCompared
		{
			get
			{
				if (_isCompared == null)
				{
					_isCompared = (CBool) CR2WTypeManager.Create("Bool", "isCompared", cr2w, this);
				}
				return _isCompared;
			}
			set
			{
				if (_isCompared == value)
				{
					return;
				}
				_isCompared = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("statMinValue")] 
		public CInt32 StatMinValue
		{
			get
			{
				if (_statMinValue == null)
				{
					_statMinValue = (CInt32) CR2WTypeManager.Create("Int32", "statMinValue", cr2w, this);
				}
				return _statMinValue;
			}
			set
			{
				if (_statMinValue == value)
				{
					return;
				}
				_statMinValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("statMaxValue")] 
		public CInt32 StatMaxValue
		{
			get
			{
				if (_statMaxValue == null)
				{
					_statMaxValue = (CInt32) CR2WTypeManager.Create("Int32", "statMaxValue", cr2w, this);
				}
				return _statMaxValue;
			}
			set
			{
				if (_statMaxValue == value)
				{
					return;
				}
				_statMaxValue = value;
				PropertySet(this);
			}
		}

		public gameStatViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
