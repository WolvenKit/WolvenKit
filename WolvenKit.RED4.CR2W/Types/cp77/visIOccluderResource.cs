using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class visIOccluderResource : ISerializable
	{
		[Ordinal(0)] [RED("resourceHash")] public CUInt32 ResourceHash { get; set; }

		public visIOccluderResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
