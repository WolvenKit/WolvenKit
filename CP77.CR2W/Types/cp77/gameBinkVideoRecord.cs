using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameBinkVideoRecord : ISerializable
	{
		[Ordinal(0)]  [RED("binkDuration")] public CFloat BinkDuration { get; set; }
		[Ordinal(1)]  [RED("resourceHash")] public CUInt64 ResourceHash { get; set; }

		public gameBinkVideoRecord(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
