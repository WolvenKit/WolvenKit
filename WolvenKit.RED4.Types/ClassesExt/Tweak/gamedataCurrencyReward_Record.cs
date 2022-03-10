
namespace WolvenKit.RED4.Types
{
	public partial class gamedataCurrencyReward_Record
	{
		[RED("amount")]
		[REDProperty(IsIgnored = true)]
		public CInt32 Amount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
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
