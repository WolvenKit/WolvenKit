using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatPoolHitPrereqCondition : BaseHitPrereqCondition
	{
		private CFloat _valueToCheck;
		private CName _objectToCheck;
		private CEnum<EComparisonType> _comparisonType;
		private CEnum<gamedataStatPoolType> _statPoolToCompare;

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("objectToCheck")] 
		public CName ObjectToCheck
		{
			get
			{
				if (_objectToCheck == null)
				{
					_objectToCheck = (CName) CR2WTypeManager.Create("CName", "objectToCheck", cr2w, this);
				}
				return _objectToCheck;
			}
			set
			{
				if (_objectToCheck == value)
				{
					return;
				}
				_objectToCheck = value;
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

		[Ordinal(4)] 
		[RED("statPoolToCompare")] 
		public CEnum<gamedataStatPoolType> StatPoolToCompare
		{
			get
			{
				if (_statPoolToCompare == null)
				{
					_statPoolToCompare = (CEnum<gamedataStatPoolType>) CR2WTypeManager.Create("gamedataStatPoolType", "statPoolToCompare", cr2w, this);
				}
				return _statPoolToCompare;
			}
			set
			{
				if (_statPoolToCompare == value)
				{
					return;
				}
				_statPoolToCompare = value;
				PropertySet(this);
			}
		}

		public StatPoolHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
