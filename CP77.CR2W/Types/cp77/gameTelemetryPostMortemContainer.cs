using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameTelemetryPostMortemContainer : ISerializable
	{
		[Ordinal(0)]  [RED("postMortem")] public gameTelemetryPostMortem PostMortem { get; set; }

		public gameTelemetryPostMortemContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
