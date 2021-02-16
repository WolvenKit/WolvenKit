using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SetDrivenKey_InternalsEntry : CVariable
	{
		[Ordinal(0)] [RED("curve")] public curveData<CFloat> Curve { get; set; }
		[Ordinal(1)] [RED("inChannelName")] public CName InChannelName { get; set; }
		[Ordinal(2)] [RED("outChannelName")] public CName OutChannelName { get; set; }
		[Ordinal(3)] [RED("inChanelType")] public CEnum<animAnimNode_SetDrivenKey_InternalsEChannelType> InChanelType { get; set; }
		[Ordinal(4)] [RED("outChanelType")] public CEnum<animAnimNode_SetDrivenKey_InternalsEChannelType> OutChanelType { get; set; }

		public animAnimNode_SetDrivenKey_InternalsEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
