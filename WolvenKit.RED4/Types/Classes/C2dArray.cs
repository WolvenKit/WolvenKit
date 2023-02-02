using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class C2dArray : CResource
	{
		[Ordinal(1)] 
		[RED("headers")] 
		public CArray<CString> Headers
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(2)] 
		[RED("data")] 
		public CArray<CArray<CString>> Data
		{
			get => GetPropertyValue<CArray<CArray<CString>>>();
			set => SetPropertyValue<CArray<CArray<CString>>>(value);
		}

		public C2dArray()
		{
			Headers = new();
			Data = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
