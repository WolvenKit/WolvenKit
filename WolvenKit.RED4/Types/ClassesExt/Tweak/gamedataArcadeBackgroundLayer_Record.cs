
namespace WolvenKit.RED4.Types
{
	public partial class gamedataArcadeBackgroundLayer_Record
	{
		[RED("imageTextureAtlas")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> ImageTextureAtlas
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("imageTexturePartList")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> ImageTexturePartList
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
	}
}
