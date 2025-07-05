
namespace WolvenKit.RED4.Types
{
	public partial class gamedataCurrencyReward_Record
	{
		[RED("currency")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Currency
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("quantityModifiers")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> QuantityModifiers
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
