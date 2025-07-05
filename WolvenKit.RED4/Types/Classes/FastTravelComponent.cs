using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FastTravelComponent : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("fastTravelNodes")] 
		public CArray<CHandle<gameFastTravelPointData>> FastTravelNodes
		{
			get => GetPropertyValue<CArray<CHandle<gameFastTravelPointData>>>();
			set => SetPropertyValue<CArray<CHandle<gameFastTravelPointData>>>(value);
		}

		public FastTravelComponent()
		{
			FastTravelNodes = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
