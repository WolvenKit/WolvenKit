using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class C2dArray : CResource
	{
		private CArray<CString> _headers;
		private CArray<CArray<CString>> _data;

		[Ordinal(1)] 
		[RED("headers")] 
		public CArray<CString> Headers
		{
			get => GetProperty(ref _headers);
			set => SetProperty(ref _headers, value);
		}

		[Ordinal(2)] 
		[RED("data")] 
		public CArray<CArray<CString>> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}
