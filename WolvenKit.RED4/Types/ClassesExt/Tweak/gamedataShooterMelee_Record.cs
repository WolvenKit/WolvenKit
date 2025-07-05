
namespace WolvenKit.RED4.Types
{
	public partial class gamedataShooterMelee_Record
	{
		[RED("animalVariant")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> AnimalVariant
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("animalVariant2")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> AnimalVariant2
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("detectionRange")]
		[REDProperty(IsIgnored = true)]
		public CFloat DetectionRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("tigerVariant")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> TigerVariant
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("tigerVariant2")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> TigerVariant2
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("wraithVariant")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> WraithVariant
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("wraithVariant2")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> WraithVariant2
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
	}
}
