using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioWwiseIgnoredNames : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("ignoredNames")] public CArray<CName> IgnoredNames { get; set; }

		public audioWwiseIgnoredNames(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
