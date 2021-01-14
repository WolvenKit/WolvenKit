using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class visIOccluderResource : ISerializable
	{
		[Ordinal(0)]  [RED("resourceHash")] public CUInt32 ResourceHash { get; set; }

		public visIOccluderResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
