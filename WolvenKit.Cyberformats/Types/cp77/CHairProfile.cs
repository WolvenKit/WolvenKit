using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CHairProfile : CResource
	{
		[Ordinal(1)] [RED("sampleCount")] public CUInt16 SampleCount { get; set; }
		[Ordinal(2)] [RED("gradientEntriesID")] public CArray<rendGradientEntry> GradientEntriesID { get; set; }
		[Ordinal(3)] [RED("gradientEntriesRootToTip")] public CArray<rendGradientEntry> GradientEntriesRootToTip { get; set; }

		public CHairProfile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
