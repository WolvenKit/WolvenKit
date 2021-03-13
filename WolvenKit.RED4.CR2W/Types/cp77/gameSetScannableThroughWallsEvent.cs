using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSetScannableThroughWallsEvent : redEvent
	{
		[Ordinal(0)] [RED("isScannableThroughWalls")] public CBool IsScannableThroughWalls { get; set; }

		public gameSetScannableThroughWallsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
