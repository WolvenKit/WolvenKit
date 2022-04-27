
namespace WolvenKit.RED4.Types
{
	public partial class gamedataBountyDrawTable_Record
	{
		[RED("bountyChoices")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> BountyChoices
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
