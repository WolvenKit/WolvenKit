using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiGridCell : RedBaseClass
	{
		private CInt32 _rarityValue;
		private CHandle<gamedataMiniGame_Trap_Record> _currentTrap;
		private CBool _isActive;

		[Ordinal(0)] 
		[RED("rarityValue")] 
		public CInt32 RarityValue
		{
			get => GetProperty(ref _rarityValue);
			set => SetProperty(ref _rarityValue, value);
		}

		[Ordinal(1)] 
		[RED("currentTrap")] 
		public CHandle<gamedataMiniGame_Trap_Record> CurrentTrap
		{
			get => GetProperty(ref _currentTrap);
			set => SetProperty(ref _currentTrap, value);
		}

		[Ordinal(2)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}
	}
}
