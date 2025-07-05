using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryTooltiData_CyberwareUpgradeData : IScriptable
	{
		[Ordinal(0)] 
		[RED("upgradeQuality")] 
		public CEnum<gamedataQuality> UpgradeQuality
		{
			get => GetPropertyValue<CEnum<gamedataQuality>>();
			set => SetPropertyValue<CEnum<gamedataQuality>>(value);
		}

		[Ordinal(1)] 
		[RED("isUpgradable")] 
		public CBool IsUpgradable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("isRipperdoc")] 
		public CBool IsRipperdoc
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("isUpgradeScreen")] 
		public CBool IsUpgradeScreen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("playerComponents")] 
		public CInt32 PlayerComponents
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("upgradeCost")] 
		public CyberwareUpgradeCostData UpgradeCost
		{
			get => GetPropertyValue<CyberwareUpgradeCostData>();
			set => SetPropertyValue<CyberwareUpgradeCostData>(value);
		}

		public InventoryTooltiData_CyberwareUpgradeData()
		{
			UpgradeCost = new CyberwareUpgradeCostData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
