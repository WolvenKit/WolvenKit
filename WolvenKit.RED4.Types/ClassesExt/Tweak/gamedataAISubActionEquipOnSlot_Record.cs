
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionEquipOnSlot_Record
	{
		[RED("animationTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat AnimationTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
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
