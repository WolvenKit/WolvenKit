using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamedeviceGenericDataContent : CVariable
	{
		[Ordinal(0)]  [RED("content")] public CArray<gamedeviceDataElement> Content { get; set; }
		[Ordinal(1)]  [RED("name")] public CString Name { get; set; }

		public gamedeviceGenericDataContent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
