using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class C2dArray_ : CResource
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

		public C2dArray_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
