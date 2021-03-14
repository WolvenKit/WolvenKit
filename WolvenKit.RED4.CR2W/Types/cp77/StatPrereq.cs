using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatPrereq : gameIScriptablePrereq
	{
		private CBool _fireAndForget;
		private CEnum<gamedataStatType> _statType;
		private CFloat _valueToCheck;
		private CEnum<EComparisonType> _comparisonType;

		[Ordinal(0)] 
		[RED("fireAndForget")] 
		public CBool FireAndForget
		{
			get
			{
				if (_fireAndForget == null)
				{
					_fireAndForget = (CBool) CR2WTypeManager.Create("Bool", "fireAndForget", cr2w, this);
				}
				return _fireAndForget;
			}
			set
			{
				if (_fireAndForget == value)
				{
					return;
				}
				_fireAndForget = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("valueToCheck")] 
		public CFloat ValueToCheck
		{
			get
			{
				if (_valueToCheck == null)
				{
					_valueToCheck = (CFloat) CR2WTypeManager.Create("Float", "valueToCheck", cr2w, this);
				}
				return _valueToCheck;
			}
			set
			{
				if (_valueToCheck == value)
				{
					return;
				}
				_valueToCheck = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get
			{
				if (_comparisonType == null)
				{
					_comparisonType = (CEnum<EComparisonType>) CR2WTypeManager.Create("EComparisonType", "comparisonType", cr2w, this);
				}
				return _comparisonType;
			}
			set
			{
				if (_comparisonType == value)
				{
					return;
				}
				_comparisonType = value;
				PropertySet(this);
			}
		}

		public StatPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
