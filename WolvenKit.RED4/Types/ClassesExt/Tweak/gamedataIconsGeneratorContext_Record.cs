
namespace WolvenKit.RED4.Types
{
	public partial class gamedataIconsGeneratorContext_Record
	{
		[RED("femalePlayerAnimSet")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> FemalePlayerAnimSet
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("malePlayerAnimSet")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> MalePlayerAnimSet
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
	}
}
