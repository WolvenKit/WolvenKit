using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioShockwavePropertyMetadata : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("eventName")] public CName EventName { get; set; }
		[Ordinal(1)]  [RED("maxDistance")] public CFloat MaxDistance { get; set; }
		[Ordinal(2)]  [RED("probability")] public CFloat Probability { get; set; }

		public audioShockwavePropertyMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
