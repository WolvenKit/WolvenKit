using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class redTaskProgressMessage : CVariable
	{
		[Ordinal(0)]  [RED("id")] public CUInt32 Id { get; set; }
		[Ordinal(1)]  [RED("processingTime")] public CFloat ProcessingTime { get; set; }
		[Ordinal(2)]  [RED("progress")] public CFloat Progress { get; set; }

		public redTaskProgressMessage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
