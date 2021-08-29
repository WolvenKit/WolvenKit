using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerDevelopmentSystem : gameScriptableSystem
	{
		private CArray<CHandle<PlayerDevelopmentData>> _playerData;
		private CArray<CHandle<PlayerDevelopmentData>> _ownerData;

		[Ordinal(0)] 
		[RED("playerData")] 
		public CArray<CHandle<PlayerDevelopmentData>> PlayerData
		{
			get => GetProperty(ref _playerData);
			set => SetProperty(ref _playerData, value);
		}

		[Ordinal(1)] 
		[RED("ownerData")] 
		public CArray<CHandle<PlayerDevelopmentData>> OwnerData
		{
			get => GetProperty(ref _ownerData);
			set => SetProperty(ref _ownerData, value);
		}
	}
}
