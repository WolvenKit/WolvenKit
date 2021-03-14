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
			get
			{
				if (_headers == null)
				{
					_headers = (CArray<CString>) CR2WTypeManager.Create("array:String", "headers", cr2w, this);
				}
				return _headers;
			}
			set
			{
				if (_headers == value)
				{
					return;
				}
				_headers = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("data")] 
		public CArray<CArray<CString>> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CArray<CArray<CString>>) CR2WTypeManager.Create("array:array:String", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		public C2dArray_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
