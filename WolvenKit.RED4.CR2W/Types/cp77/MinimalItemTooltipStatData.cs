using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MinimalItemTooltipStatData : IScriptable
	{
		private CFloat _value;
		private CFloat _diff;
		private CString _statName;
		private CEnum<gamedataStatType> _type;
		private CBool _isPercentage;
		private CBool _roundValue;
		private CBool _displayPlus;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("diff")] 
		public CFloat Diff
		{
			get
			{
				if (_diff == null)
				{
					_diff = (CFloat) CR2WTypeManager.Create("Float", "diff", cr2w, this);
				}
				return _diff;
			}
			set
			{
				if (_diff == value)
				{
					return;
				}
				_diff = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("isPercentage")] 
		public CBool IsPercentage
		{
			get
			{
				if (_isPercentage == null)
				{
					_isPercentage = (CBool) CR2WTypeManager.Create("Bool", "isPercentage", cr2w, this);
				}
				return _isPercentage;
			}
			set
			{
				if (_isPercentage == value)
				{
					return;
				}
				_isPercentage = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("roundValue")] 
		public CBool RoundValue
		{
			get
			{
				if (_roundValue == null)
				{
					_roundValue = (CBool) CR2WTypeManager.Create("Bool", "roundValue", cr2w, this);
				}
				return _roundValue;
			}
			set
			{
				if (_roundValue == value)
				{
					return;
				}
				_roundValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("displayPlus")] 
		public CBool DisplayPlus
		{
			get
			{
				if (_displayPlus == null)
				{
					_displayPlus = (CBool) CR2WTypeManager.Create("Bool", "displayPlus", cr2w, this);
				}
				return _displayPlus;
			}
			set
			{
				if (_displayPlus == value)
				{
					return;
				}
				_displayPlus = value;
				PropertySet(this);
			}
		}

		public MinimalItemTooltipStatData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
