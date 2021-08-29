using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class physicsDestructionLevelData : RedBaseClass
	{
		private CHandle<physicsFilterData> _filterData;
		private CResourceAsyncReference<worldEffect> _fracturingEffect;

		[Ordinal(0)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetProperty(ref _filterData);
			set => SetProperty(ref _filterData, value);
		}

		[Ordinal(1)] 
		[RED("fracturingEffect")] 
		public CResourceAsyncReference<worldEffect> FracturingEffect
		{
			get => GetProperty(ref _fracturingEffect);
			set => SetProperty(ref _fracturingEffect, value);
		}
	}
}
