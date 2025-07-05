using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameCookedLootData : ISerializable
	{
		[Ordinal(0)] 
		[RED("lootTables")] 
		public CArray<TweakDBID> LootTables
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		[Ordinal(1)] 
		[RED("contentAssignment")] 
		public TweakDBID ContentAssignment
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public gameCookedLootData()
		{
			LootTables = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
