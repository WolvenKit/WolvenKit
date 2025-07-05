using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameFlattenedLootData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("lootID")] 
		public TweakDBID LootID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public gameFlattenedLootData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
