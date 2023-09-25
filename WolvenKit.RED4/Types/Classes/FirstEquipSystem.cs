using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FirstEquipSystem : gameScriptableSystem
	{
		[Ordinal(0)] 
		[RED("equipDataArray")] 
		public CArray<EFirstEquipData> EquipDataArray
		{
			get => GetPropertyValue<CArray<EFirstEquipData>>();
			set => SetPropertyValue<CArray<EFirstEquipData>>(value);
		}

		public FirstEquipSystem()
		{
			EquipDataArray = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
