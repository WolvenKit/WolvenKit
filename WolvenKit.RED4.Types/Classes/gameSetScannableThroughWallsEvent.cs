using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSetScannableThroughWallsEvent : redEvent
	{
		private CBool _isScannableThroughWalls;

		[Ordinal(0)] 
		[RED("isScannableThroughWalls")] 
		public CBool IsScannableThroughWalls
		{
			get => GetProperty(ref _isScannableThroughWalls);
			set => SetProperty(ref _isScannableThroughWalls, value);
		}
	}
}
