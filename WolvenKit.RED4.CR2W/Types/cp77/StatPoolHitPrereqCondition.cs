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
			get => GetProperty(ref _valueToCheck);
			set => SetProperty(ref _valueToCheck, value);
		}

		[Ordinal(2)] 
		[RED("objectToCheck")] 
		public CName ObjectToCheck
		{
			get => GetProperty(ref _objectToCheck);
			set => SetProperty(ref _objectToCheck, value);
		}

		[Ordinal(3)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get => GetProperty(ref _comparisonType);
			set => SetProperty(ref _comparisonType, value);
		}

		[Ordinal(4)] 
		[RED("statPoolToCompare")] 
		public CEnum<gamedataStatPoolType> StatPoolToCompare
		{
			get => GetProperty(ref _statPoolToCompare);
			set => SetProperty(ref _statPoolToCompare, value);
		}

		public StatPoolHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
