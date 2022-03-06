
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionSetUnequipPrimaryWeapons_Record
	{
		[RED("animationTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat AnimationTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("dropItem")]
		[REDProperty(IsIgnored = true)]
		public CBool DropItem
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
