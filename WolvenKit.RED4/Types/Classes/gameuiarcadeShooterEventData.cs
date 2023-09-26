using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeShooterEventData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("triggerPosition")] 
		public Vector2 TriggerPosition
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(1)] 
		[RED("finalPosition")] 
		public Vector2 FinalPosition
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(2)] 
		[RED("spawnerDataList")] 
		public CArray<gameuiarcadeShooterEventSpawnerData> SpawnerDataList
		{
			get => GetPropertyValue<CArray<gameuiarcadeShooterEventSpawnerData>>();
			set => SetPropertyValue<CArray<gameuiarcadeShooterEventSpawnerData>>(value);
		}

		public gameuiarcadeShooterEventData()
		{
			TriggerPosition = new Vector2();
			FinalPosition = new Vector2();
			SpawnerDataList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
