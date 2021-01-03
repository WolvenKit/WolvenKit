using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CHairProfile : CResource
	{
		[Ordinal(0)]  [RED("gradientEntriesID")] public CArray<rendGradientEntry> GradientEntriesID { get; set; }
		[Ordinal(1)]  [RED("gradientEntriesRootToTip")] public CArray<rendGradientEntry> GradientEntriesRootToTip { get; set; }
		[Ordinal(2)]  [RED("sampleCount")] public CUInt16 SampleCount { get; set; }

		public CHairProfile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
