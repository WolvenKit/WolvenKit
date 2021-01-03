using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class interopGraphConnectionCreationData : CVariable
	{
		[Ordinal(0)]  [RED("data")] public CString Data { get; set; }
		[Ordinal(1)]  [RED("extraData")] public CArray<CString> ExtraData { get; set; }

		public interopGraphConnectionCreationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
