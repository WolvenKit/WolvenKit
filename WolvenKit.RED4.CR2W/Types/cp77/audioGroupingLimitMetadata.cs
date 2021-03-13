using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioGroupingLimitMetadata : audioAudioMetadata
	{
		[Ordinal(1)] [RED("limit")] public CFloat Limit { get; set; }

		public audioGroupingLimitMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
