using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questDistanceComparison_ConditionType : questIDistanceConditionType
	{
		private CHandle<questObjectDistance> _distanceDefinition1;
		private CHandle<questValueDistance> _distanceDefinition2;
		private CEnum<EComparisonType> _comparisonType;

		[Ordinal(0)] 
		[RED("distanceDefinition1")] 
		public CHandle<questObjectDistance> DistanceDefinition1
		{
			get
			{
				if (_distanceDefinition1 == null)
				{
					_distanceDefinition1 = (CHandle<questObjectDistance>) CR2WTypeManager.Create("handle:questObjectDistance", "distanceDefinition1", cr2w, this);
				}
				return _distanceDefinition1;
			}
			set
			{
				if (_distanceDefinition1 == value)
				{
					return;
				}
				_distanceDefinition1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("distanceDefinition2")] 
		public CHandle<questValueDistance> DistanceDefinition2
		{
			get
			{
				if (_distanceDefinition2 == null)
				{
					_distanceDefinition2 = (CHandle<questValueDistance>) CR2WTypeManager.Create("handle:questValueDistance", "distanceDefinition2", cr2w, this);
				}
				return _distanceDefinition2;
			}
			set
			{
				if (_distanceDefinition2 == value)
				{
					return;
				}
				_distanceDefinition2 = value;
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

		public questDistanceComparison_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
