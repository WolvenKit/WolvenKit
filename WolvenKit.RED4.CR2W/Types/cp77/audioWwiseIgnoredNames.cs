using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioWwiseIgnoredNames : audioAudioMetadata
	{
		[Ordinal(1)] [RED("ignoredNames")] public CArray<CName> IgnoredNames { get; set; }

		public audioWwiseIgnoredNames(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
