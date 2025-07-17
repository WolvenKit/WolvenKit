
namespace WolvenKit.RED4.Types
{
	public partial class gamedataControlledLootSet_Record
	{
		[RED("blocksFromNPCs")]
		[REDProperty(IsIgnored = true)]
		public CBool BlocksFromNPCs
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("blocksInContainers")]
		[REDProperty(IsIgnored = true)]
		public CBool BlocksInContainers
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("chanceBase")]
		[REDProperty(IsIgnored = true)]
		public CFloat ChanceBase
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("chanceIncreasePerAttempt")]
		[REDProperty(IsIgnored = true)]
		public CFloat ChanceIncreasePerAttempt
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("chanceMax")]
		[REDProperty(IsIgnored = true)]
		public CFloat ChanceMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("dropsFromNPCs")]
		[REDProperty(IsIgnored = true)]
		public CBool DropsFromNPCs
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("dropsInContainers")]
		[REDProperty(IsIgnored = true)]
		public CBool DropsInContainers
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("excludedContainerTypes")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ExcludedContainerTypes
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("itemsInSetShareDropCount")]
		[REDProperty(IsIgnored = true)]
		public CBool ItemsInSetShareDropCount
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("lootItems")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> LootItems
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("maxDrops")]
		[REDProperty(IsIgnored = true)]
		public CInt32 MaxDrops
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("maxDropsGloballyShared")]
		[REDProperty(IsIgnored = true)]
		public CBool MaxDropsGloballyShared
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("maxDropsPerLevel")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxDropsPerLevel
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("npcPrereqID")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID NpcPrereqID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("playerPrereqID")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID PlayerPrereqID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("progressionBasedChanceBonus")]
		[REDProperty(IsIgnored = true)]
		public CFloat ProgressionBasedChanceBonus
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("progressionBasedThreshold")]
		[REDProperty(IsIgnored = true)]
		public CFloat ProgressionBasedThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("replacementLootItems")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ReplacementLootItems
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("replacementQueries")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ReplacementQueries
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		[RED("rollBackCounterWhenLootIsDestroyed")]
		[REDProperty(IsIgnored = true)]
		public CBool RollBackCounterWhenLootIsDestroyed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[RED("rollOverDropsPerLevel")]
		[REDProperty(IsIgnored = true)]
		public CBool RollOverDropsPerLevel
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
