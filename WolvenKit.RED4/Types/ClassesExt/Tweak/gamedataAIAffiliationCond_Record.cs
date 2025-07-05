
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIAffiliationCond_Record
	{
		[RED("affiliation")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Affiliation
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
