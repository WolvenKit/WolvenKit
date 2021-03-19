using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSetScannableThroughWallsEvent : redEvent
	{
		private CBool _isScannableThroughWalls;

		[Ordinal(0)] 
		[RED("isScannableThroughWalls")] 
		public CBool IsScannableThroughWalls
		{
			get => GetProperty(ref _isScannableThroughWalls);
			set => SetProperty(ref _isScannableThroughWalls, value);
		}

		public gameSetScannableThroughWallsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
