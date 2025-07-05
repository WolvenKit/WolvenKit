
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleOffer_Record
	{
		[RED("availabilityFact")]
		[REDProperty(IsIgnored = true)]
		public CName AvailabilityFact
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("brandName")]
		[REDProperty(IsIgnored = true)]
		public CName BrandName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("description")]
		[REDProperty(IsIgnored = true)]
		public CString Description
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("discountApplicable")]
		[REDProperty(IsIgnored = true)]
		public CBool DiscountApplicable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("hasCustomization")]
		[REDProperty(IsIgnored = true)]
		public CBool HasCustomization
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("hasMachineGun")]
		[REDProperty(IsIgnored = true)]
		public CBool HasMachineGun
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("hasRocketLauncher")]
		[REDProperty(IsIgnored = true)]
		public CBool HasRocketLauncher
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("ownershipFact")]
		[REDProperty(IsIgnored = true)]
		public CName OwnershipFact
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("unlockType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID UnlockType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
