using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnCheckPlayerTargetEntityDistanceInterruptConditionParams : RedBaseClass
	{
		private CFloat _distance;
		private CEnum<EComparisonType> _comparisonType;
		private gameEntityReference _targetEntity;

		[Ordinal(0)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get => GetProperty(ref _distance);
			set => SetProperty(ref _distance, value);
		}

		[Ordinal(1)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get => GetProperty(ref _comparisonType);
			set => SetProperty(ref _comparisonType, value);
		}

		[Ordinal(2)] 
		[RED("targetEntity")] 
		public gameEntityReference TargetEntity
		{
			get => GetProperty(ref _targetEntity);
			set => SetProperty(ref _targetEntity, value);
		}
	}
}
