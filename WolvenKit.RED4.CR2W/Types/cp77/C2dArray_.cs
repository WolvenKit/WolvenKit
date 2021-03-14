using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class C2dArray_ : CResource
	{
		[Ordinal(1)] [RED("headers")] public CArray<CString> Headers { get; set; }
		[Ordinal(2)] [RED("data")] public CArray<CArray<CString>> Data { get; set; }

		public C2dArray_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
