using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStatDetailedData : CVariable
	{
		private CEnum<gamedataStatType> _statType;
		private CFloat _limitMin;
		private CFloat _limitMax;
		private CFloat _value;
		private CArray<gameStatModifierDetailedData> _modifiers;
		private CBool _boolStatType;

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
		[RED("limitMin")] 
		public CFloat LimitMin
		{
			get
			{
				if (_limitMin == null)
				{
					_limitMin = (CFloat) CR2WTypeManager.Create("Float", "limitMin", cr2w, this);
				}
				return _limitMin;
			}
			set
			{
				if (_limitMin == value)
				{
					return;
				}
				_limitMin = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("limitMax")] 
		public CFloat LimitMax
		{
			get
			{
				if (_limitMax == null)
				{
					_limitMax = (CFloat) CR2WTypeManager.Create("Float", "limitMax", cr2w, this);
				}
				return _limitMax;
			}
			set
			{
				if (_limitMax == value)
				{
					return;
				}
				_limitMax = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("value")] 
		public CFloat Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CFloat) CR2WTypeManager.Create("Float", "value", cr2w, this);
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

		[Ordinal(4)] 
		[RED("modifiers")] 
		public CArray<gameStatModifierDetailedData> Modifiers
		{
			get
			{
				if (_modifiers == null)
				{
					_modifiers = (CArray<gameStatModifierDetailedData>) CR2WTypeManager.Create("array:gameStatModifierDetailedData", "modifiers", cr2w, this);
				}
				return _modifiers;
			}
			set
			{
				if (_modifiers == value)
				{
					return;
				}
				_modifiers = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("boolStatType")] 
		public CBool BoolStatType
		{
			get
			{
				if (_boolStatType == null)
				{
					_boolStatType = (CBool) CR2WTypeManager.Create("Bool", "boolStatType", cr2w, this);
				}
				return _boolStatType;
			}
			set
			{
				if (_boolStatType == value)
				{
					return;
				}
				_boolStatType = value;
				PropertySet(this);
			}
		}

		public gameStatDetailedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
