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
			AreaData = new gameAreaData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
