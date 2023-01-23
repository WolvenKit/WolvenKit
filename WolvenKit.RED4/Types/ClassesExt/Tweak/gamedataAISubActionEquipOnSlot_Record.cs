
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionEquipOnSlot_Record
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
