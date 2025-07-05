
namespace WolvenKit.RED4.Types
{
	public partial class gamedataSceneResources_Record
	{
		[RED("resRefs")]
		[REDProperty(IsIgnored = true)]
		public CArray<CResourceAsyncReference<CResource>> ResRefs
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<CResource>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<CResource>>>(value);
		}
	}
}
