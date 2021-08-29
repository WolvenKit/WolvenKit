using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiRoachRaceChunk : RedBaseClass
	{
		private CArray<gameuiRoachRaceObstacle> _obstacles;

		[Ordinal(0)] 
		[RED("obstacles")] 
		public CArray<gameuiRoachRaceObstacle> Obstacles
		{
			get => GetProperty(ref _obstacles);
			set => SetProperty(ref _obstacles, value);
		}
	}
}
