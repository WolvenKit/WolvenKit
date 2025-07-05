using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiRoachRaceChunk : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("obstacles")] 
		public CArray<gameuiRoachRaceObstacle> Obstacles
		{
			get => GetPropertyValue<CArray<gameuiRoachRaceObstacle>>();
			set => SetPropertyValue<CArray<gameuiRoachRaceObstacle>>(value);
		}

		public gameuiRoachRaceChunk()
		{
			Obstacles = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
