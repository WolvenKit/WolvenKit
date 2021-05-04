using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questDistanceVsDistanceComparison_ConditionType : questIDistanceConditionType
	{
		private CHandle<questObjectDistance> _distanceDefinition1;
		private CHandle<questObjectDistance> _distanceDefinition2;
		private CEnum<EComparisonType> _comparisonType;

		[Ordinal(0)] 
		[RED("distanceDefinition1")] 
		public CHandle<questObjectDistance> DistanceDefinition1
		{
			get => GetProperty(ref _distanceDefinition1);
			set => SetProperty(ref _distanceDefinition1, value);
		}

		[Ordinal(1)] 
		[RED("distanceDefinition2")] 
		public CHandle<questObjectDistance> DistanceDefinition2
		{
			get => GetProperty(ref _distanceDefinition2);
			set => SetProperty(ref _distanceDefinition2, value);
		}

		[Ordinal(2)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get => GetProperty(ref _comparisonType);
			set => SetProperty(ref _comparisonType, value);
		}

		public questDistanceVsDistanceComparison_ConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
