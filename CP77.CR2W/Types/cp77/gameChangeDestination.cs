using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameChangeDestination : gameActionInternalEvent
	{
		[Ordinal(0)]  [RED("destination")] public Vector4 Destination { get; set; }

		public gameChangeDestination(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
