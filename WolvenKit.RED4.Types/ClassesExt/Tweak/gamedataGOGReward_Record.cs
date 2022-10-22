
namespace WolvenKit.RED4.Types
{
	public partial class gamedataGOGReward_Record
	{
		[RED("description")]
		[REDProperty(IsIgnored = true)]
		public gamedataLocKeyWrapper Description
		{
			get => GetPropertyValue<gamedataLocKeyWrapper>();
			set => SetPropertyValue<gamedataLocKeyWrapper>(value);
		}
		
		[RED("displayName")]
		[REDProperty(IsIgnored = true)]
		public gamedataLocKeyWrapper DisplayName
		{
			get => GetPropertyValue<gamedataLocKeyWrapper>();
			set => SetPropertyValue<gamedataLocKeyWrapper>(value);
		}
		
		[RED("iconsAtlasSlot")]
		[REDProperty(IsIgnored = true)]
		public CName IconsAtlasSlot
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("rewardToken")]
		[REDProperty(IsIgnored = true)]
		public CInt32 RewardToken
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
