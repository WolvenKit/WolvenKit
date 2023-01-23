
namespace WolvenKit.RED4.Types
{
	public partial class gamedataRewardSet_Record
	{
		[RED("rewardItems")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> RewardItems
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
