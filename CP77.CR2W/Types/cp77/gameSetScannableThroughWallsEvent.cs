using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameSetScannableThroughWallsEvent : redEvent
	{
		[Ordinal(0)]  [RED("isScannableThroughWalls")] public CBool IsScannableThroughWalls { get; set; }

		public gameSetScannableThroughWallsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
