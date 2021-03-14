using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questVarVsVarComparison_ConditionType : questIFactsDBConditionType
	{
		private CString _factName1;
		private CString _factName2;
		private CEnum<EComparisonType> _comparisonType;

		[Ordinal(0)] 
		[RED("factName1")] 
		public CString FactName1
		{
			get
			{
				if (_factName1 == null)
				{
					_factName1 = (CString) CR2WTypeManager.Create("String", "factName1", cr2w, this);
				}
				return _factName1;
			}
			set
			{
				if (_factName1 == value)
				{
					return;
				}
				_factName1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("factName2")] 
		public CString FactName2
		{
			get
			{
				if (_factName2 == null)
				{
					_factName2 = (CString) CR2WTypeManager.Create("String", "factName2", cr2w, this);
				}
				return _factName2;
			}
			set
			{
				if (_factName2 == value)
				{
					return;
				}
				_factName2 = value;
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

		public questVarVsVarComparison_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
