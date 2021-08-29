using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameFlattenedLootData : RedBaseClass
	{
		private TweakDBID _lootID;

		[Ordinal(0)] 
		[RED("lootID")] 
		public TweakDBID LootID
		{
			get => GetProperty(ref _lootID);
			set => SetProperty(ref _lootID, value);
		}
	}
}
