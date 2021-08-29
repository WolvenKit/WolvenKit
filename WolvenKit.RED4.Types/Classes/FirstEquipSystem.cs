using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FirstEquipSystem : gameScriptableSystem
	{
		private CArray<EFirstEquipData> _equipDataArray;

		[Ordinal(0)] 
		[RED("equipDataArray")] 
		public CArray<EFirstEquipData> EquipDataArray
		{
			get => GetProperty(ref _equipDataArray);
			set => SetProperty(ref _equipDataArray, value);
		}
	}
}
