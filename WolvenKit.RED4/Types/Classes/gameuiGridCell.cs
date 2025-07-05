using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiGridCell : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("rarityValue")] 
		public CInt32 RarityValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("currentTrap")] 
		public CHandle<gamedataMiniGame_Trap_Record> CurrentTrap
		{
			get => GetPropertyValue<CHandle<gamedataMiniGame_Trap_Record>>();
			set => SetPropertyValue<CHandle<gamedataMiniGame_Trap_Record>>(value);
		}

		[Ordinal(2)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameuiGridCell()
		{
			IsActive = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
