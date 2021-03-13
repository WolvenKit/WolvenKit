using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiBraindanceClueDescriptor : CVariable
	{
		[Ordinal(0)] [RED("mode")] public CEnum<gameuiEClueDescriptorMode> Mode { get; set; }
		[Ordinal(1)] [RED("layer")] public CEnum<gameuiEBraindanceLayer> Layer { get; set; }
		[Ordinal(2)] [RED("startTime")] public CFloat StartTime { get; set; }
		[Ordinal(3)] [RED("endTime")] public CFloat EndTime { get; set; }
		[Ordinal(4)] [RED("clueName")] public CName ClueName { get; set; }

		public gameuiBraindanceClueDescriptor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
