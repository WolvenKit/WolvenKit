using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AntiRadar : gameweaponObject
	{
		[Ordinal(59)] 
		[RED("colliderComponent")] 
		public CHandle<entIComponent> ColliderComponent
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		[Ordinal(60)] 
		[RED("gameEffectRef")] 
		public gameEffectRef GameEffectRef
		{
			get => GetPropertyValue<gameEffectRef>();
			set => SetPropertyValue<gameEffectRef>(value);
		}

		[Ordinal(61)] 
		[RED("gameEffectInstance")] 
		public CHandle<gameEffectInstance> GameEffectInstance
		{
			get => GetPropertyValue<CHandle<gameEffectInstance>>();
			set => SetPropertyValue<CHandle<gameEffectInstance>>(value);
		}

		[Ordinal(62)] 
		[RED("jammedSensorsArray")] 
		public CArray<CWeakHandle<SensorDevice>> JammedSensorsArray
		{
			get => GetPropertyValue<CArray<CWeakHandle<SensorDevice>>>();
			set => SetPropertyValue<CArray<CWeakHandle<SensorDevice>>>(value);
		}

		public AntiRadar()
		{
			GameEffectRef = new gameEffectRef();
			JammedSensorsArray = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
