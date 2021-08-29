using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EquipmentSystem : gameScriptableSystem
	{
		private CArray<CHandle<EquipmentSystemPlayerData>> _ownerData;

		[Ordinal(0)] 
		[RED("ownerData")] 
		public CArray<CHandle<EquipmentSystemPlayerData>> OwnerData
		{
			get => GetProperty(ref _ownerData);
			set => SetProperty(ref _ownerData, value);
		}
	}
}
