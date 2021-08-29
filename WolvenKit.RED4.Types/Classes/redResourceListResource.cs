using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class redResourceListResource : CResource
	{
		private CArray<CResourceAsyncReference<CResource>> _resources;
		private CArray<CString> _descriptions;

		[Ordinal(1)] 
		[RED("resources")] 
		public CArray<CResourceAsyncReference<CResource>> Resources
		{
			get => GetProperty(ref _resources);
			set => SetProperty(ref _resources, value);
		}

		[Ordinal(2)] 
		[RED("descriptions")] 
		public CArray<CString> Descriptions
		{
			get => GetProperty(ref _descriptions);
			set => SetProperty(ref _descriptions, value);
		}
	}
}
