
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVendorWare_Record
	{
		[RED("availabilityPrereq")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID AvailabilityPrereq
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("forceQuality")]
		[REDProperty(IsIgnored = true)]
		public CName ForceQuality
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("generationPrereqs")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> GenerationPrereqs
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("quantity")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Quantity
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
