
namespace WolvenKit.RED4.Types
{
	public partial class gamedataRigs_Record
	{
		[RED("rigsResRefs")]
		[REDProperty(IsIgnored = true)]
		public CArray<CResourceAsyncReference<CResource>> RigsResRefs
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<CResource>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<CResource>>>(value);
		}
	}
}
