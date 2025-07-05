
namespace WolvenKit.RED4.Types
{
	public partial class gamedataUICharacterCustomizationResourcePaths_Record
	{
		[RED("femalePath")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> FemalePath
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("malePath")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> MalePath
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
	}
}
