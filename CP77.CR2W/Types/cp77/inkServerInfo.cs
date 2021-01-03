using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkServerInfo : IScriptable
	{
		[Ordinal(0)]  [RED("address")] public CString Address { get; set; }
		[Ordinal(1)]  [RED("hostname")] public CString Hostname { get; set; }
		[Ordinal(2)]  [RED("kind")] public CString Kind { get; set; }
		[Ordinal(3)]  [RED("number")] public CInt32 Number { get; set; }
		[Ordinal(4)]  [RED("worldDescription")] public CString WorldDescription { get; set; }

		public inkServerInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
