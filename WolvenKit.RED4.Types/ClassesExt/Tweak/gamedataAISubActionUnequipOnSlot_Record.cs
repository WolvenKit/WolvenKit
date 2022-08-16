
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionUnequipOnSlot_Record
	{
		[RED("useItemSpawnDelayFromWeapon")]
		[REDProperty(IsIgnored = true)]
		public CBool UseItemSpawnDelayFromWeapon
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
