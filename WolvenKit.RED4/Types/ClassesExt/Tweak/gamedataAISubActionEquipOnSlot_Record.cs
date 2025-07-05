
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionEquipOnSlot_Record
	{
		[RED("cacheEquippedItem")]
		[REDProperty(IsIgnored = true)]
		public CBool CacheEquippedItem
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("useItemSpawnDelayFromWeapon")]
		[REDProperty(IsIgnored = true)]
		public CBool UseItemSpawnDelayFromWeapon
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
