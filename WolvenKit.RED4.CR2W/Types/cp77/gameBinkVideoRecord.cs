using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameBinkVideoRecord : ISerializable
	{
		[Ordinal(0)] [RED("resourceHash")] public CUInt64 ResourceHash { get; set; }
		[Ordinal(1)] [RED("binkDuration")] public CFloat BinkDuration { get; set; }

		public gameBinkVideoRecord(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
