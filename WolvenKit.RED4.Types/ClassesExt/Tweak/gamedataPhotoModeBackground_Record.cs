
namespace WolvenKit.RED4.Types
{
	public partial class gamedataPhotoModeBackground_Record
	{
		[RED("textureName")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> TextureName
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
	}
}
