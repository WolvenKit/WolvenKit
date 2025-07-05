using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameAreaVolume : gameObject
	{
		[Ordinal(36)] 
		[RED("areaData")] 
		public gameAreaData AreaData
		{
			get => GetPropertyValue<gameAreaData>();
			set => SetPropertyValue<gameAreaData>(value);
		}

		public gameAreaVolume()
		{
			AreaData = new gameAreaData { Position = new Vector4 { W = 1.000000F }, Size = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
