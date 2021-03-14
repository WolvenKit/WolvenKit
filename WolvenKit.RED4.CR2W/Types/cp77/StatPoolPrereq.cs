using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatPoolPrereq : gameIScriptablePrereq
	{
		private CEnum<gamedataStatPoolType> _statPoolType;
		private CFloat _valueToCheck;
		private CEnum<EComparisonType> _comparisonType;
		private CBool _skipOnApply;
		private CBool _comparePercentage;

		[Ordinal(0)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get
			{
				if (_statPoolType == null)
				{
					_statPoolType = (CEnum<gamedataStatPoolType>) CR2WTypeManager.Create("gamedataStatPoolType", "statPoolType", cr2w, this);
				}
				return _statPoolType;
			}
			set
			{
				if (_statPoolType == value)
				{
					return;
				}
				_statPoolType = value;
				PropertySet(this);
			}
		}

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

		[Ordinal(3)] 
		[RED("skipOnApply")] 
		public CBool SkipOnApply
		{
			get
			{
				if (_skipOnApply == null)
				{
					_skipOnApply = (CBool) CR2WTypeManager.Create("Bool", "skipOnApply", cr2w, this);
				}
				return _skipOnApply;
			}
			set
			{
				if (_skipOnApply == value)
				{
					return;
				}
				_skipOnApply = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("comparePercentage")] 
		public CBool ComparePercentage
		{
			get
			{
				if (_comparePercentage == null)
				{
					_comparePercentage = (CBool) CR2WTypeManager.Create("Bool", "comparePercentage", cr2w, this);
				}
				return _comparePercentage;
			}
			set
			{
				if (_comparePercentage == value)
				{
					return;
				}
				_comparePercentage = value;
				PropertySet(this);
			}
		}

		public StatPoolPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
