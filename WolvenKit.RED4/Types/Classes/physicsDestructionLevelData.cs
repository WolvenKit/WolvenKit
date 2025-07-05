using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsDestructionLevelData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetPropertyValue<CHandle<physicsFilterData>>();
			set => SetPropertyValue<CHandle<physicsFilterData>>(value);
		}

		[Ordinal(1)] 
		[RED("fracturingEffect")] 
		public CResourceAsyncReference<worldEffect> FracturingEffect
		{
			get => GetPropertyValue<CResourceAsyncReference<worldEffect>>();
			set => SetPropertyValue<CResourceAsyncReference<worldEffect>>(value);
		}

		public physicsDestructionLevelData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
