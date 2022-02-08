using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class redResourceListResource : CResource
	{
		[Ordinal(1)] 
		[RED("resources")] 
		public CArray<CResourceAsyncReference<CResource>> Resources
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<CResource>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<CResource>>>(value);
		}

		[Ordinal(2)] 
		[RED("descriptions")] 
		public CArray<CString> Descriptions
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		public redResourceListResource()
		{
			Resources = new();
			Descriptions = new();
		}
	}
}
