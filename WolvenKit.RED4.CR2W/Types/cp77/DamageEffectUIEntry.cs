using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DamageEffectUIEntry : IScriptable
	{
		private CEnum<gamedataStatType> _valueStat;
		private CEnum<gamedataStatType> _targetStat;
		private CEnum<DamageEffectDisplayType> _displayType;
		private CFloat _valueToDisplay;
		private CFloat _effectorDuration;
		private CFloat _effectorDelay;
		private CBool _isContinuous;

		[Ordinal(0)] 
		[RED("valueStat")] 
		public CEnum<gamedataStatType> ValueStat
		{
			get
			{
				if (_valueStat == null)
				{
					_valueStat = (CEnum<gamedataStatType>) CR2WTypeManager.Create("gamedataStatType", "valueStat", cr2w, this);
				}
				return _valueStat;
			}
			set
			{
				if (_valueStat == value)
				{
					return;
				}
				_valueStat = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("targetStat")] 
		public CEnum<gamedataStatType> TargetStat
		{
			get
			{
				if (_targetStat == null)
				{
					_targetStat = (CEnum<gamedataStatType>) CR2WTypeManager.Create("gamedataStatType", "targetStat", cr2w, this);
				}
				return _targetStat;
			}
			set
			{
				if (_targetStat == value)
				{
					return;
				}
				_targetStat = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("displayType")] 
		public CEnum<DamageEffectDisplayType> DisplayType
		{
			get
			{
				if (_displayType == null)
				{
					_displayType = (CEnum<DamageEffectDisplayType>) CR2WTypeManager.Create("DamageEffectDisplayType", "displayType", cr2w, this);
				}
				return _displayType;
			}
			set
			{
				if (_displayType == value)
				{
					return;
				}
				_displayType = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("valueToDisplay")] 
		public CFloat ValueToDisplay
		{
			get
			{
				if (_valueToDisplay == null)
				{
					_valueToDisplay = (CFloat) CR2WTypeManager.Create("Float", "valueToDisplay", cr2w, this);
				}
				return _valueToDisplay;
			}
			set
			{
				if (_valueToDisplay == value)
				{
					return;
				}
				_valueToDisplay = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("effectorDuration")] 
		public CFloat EffectorDuration
		{
			get
			{
				if (_effectorDuration == null)
				{
					_effectorDuration = (CFloat) CR2WTypeManager.Create("Float", "effectorDuration", cr2w, this);
				}
				return _effectorDuration;
			}
			set
			{
				if (_effectorDuration == value)
				{
					return;
				}
				_effectorDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("effectorDelay")] 
		public CFloat EffectorDelay
		{
			get
			{
				if (_effectorDelay == null)
				{
					_effectorDelay = (CFloat) CR2WTypeManager.Create("Float", "effectorDelay", cr2w, this);
				}
				return _effectorDelay;
			}
			set
			{
				if (_effectorDelay == value)
				{
					return;
				}
				_effectorDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isContinuous")] 
		public CBool IsContinuous
		{
			get
			{
				if (_isContinuous == null)
				{
					_isContinuous = (CBool) CR2WTypeManager.Create("Bool", "isContinuous", cr2w, this);
				}
				return _isContinuous;
			}
			set
			{
				if (_isContinuous == value)
				{
					return;
				}
				_isContinuous = value;
				PropertySet(this);
			}
		}

		public DamageEffectUIEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
