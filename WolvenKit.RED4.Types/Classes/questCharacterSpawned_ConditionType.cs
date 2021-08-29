using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCharacterSpawned_ConditionType : questICharacterConditionType
	{
		private gameEntityReference _objectRef;
		private CHandle<questComparisonParam> _comparisonParams;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(1)] 
		[RED("comparisonParams")] 
		public CHandle<questComparisonParam> ComparisonParams
		{
			get => GetProperty(ref _comparisonParams);
			set => SetProperty(ref _comparisonParams, value);
		}
	}
}
