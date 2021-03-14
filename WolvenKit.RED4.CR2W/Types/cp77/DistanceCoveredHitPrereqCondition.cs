using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DistanceCoveredHitPrereqCondition : BaseHitPrereqCondition
	{
		private CFloat _distanceRequired;
		private CEnum<EComparisonType> _comparisonType;

		[Ordinal(1)] 
		[RED("distanceRequired")] 
		public CFloat DistanceRequired
		{
			get
			{
				if (_distanceRequired == null)
				{
					_distanceRequired = (CFloat) CR2WTypeManager.Create("Float", "distanceRequired", cr2w, this);
				}
				return _distanceRequired;
			}
			set
			{
				if (_distanceRequired == value)
				{
					return;
				}
				_distanceRequired = value;
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

		public DistanceCoveredHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
