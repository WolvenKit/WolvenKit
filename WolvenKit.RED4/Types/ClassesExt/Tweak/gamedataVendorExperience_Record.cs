
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVendorExperience_Record
	{
		[RED("pricePerPoint")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> PricePerPoint
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("proficiency")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Proficiency
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
