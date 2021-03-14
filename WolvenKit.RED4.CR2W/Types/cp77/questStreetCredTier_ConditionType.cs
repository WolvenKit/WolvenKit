using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questStreetCredTier_ConditionType : questIStatsConditionType
	{
		private TweakDBID _tierID;
		private CEnum<EComparisonType> _comparisonType;

		[Ordinal(0)] 
		[RED("tierID")] 
		public TweakDBID TierID
		{
			get
			{
				if (_tierID == null)
				{
					_tierID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "tierID", cr2w, this);
				}
				return _tierID;
			}
			set
			{
				if (_tierID == value)
				{
					return;
				}
				_tierID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		public questStreetCredTier_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
