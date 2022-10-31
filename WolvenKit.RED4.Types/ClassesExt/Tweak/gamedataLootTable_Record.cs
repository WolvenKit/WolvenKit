
namespace WolvenKit.RED4.Types
{
	public partial class gamedataLootTable_Record
	{
		[RED("lootGenerationType")]
		[REDProperty(IsIgnored = true)]
		public CString LootGenerationType
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("lootItems")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> LootItems
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("lootTableInclusions")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> LootTableInclusions
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("maxItemsToLoot")]
		[REDProperty(IsIgnored = true)]
		public CInt32 MaxItemsToLoot
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("minItemsToLoot")]
		[REDProperty(IsIgnored = true)]
		public CInt32 MinItemsToLoot
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("queries")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Queries
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
