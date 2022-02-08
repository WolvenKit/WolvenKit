using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AntiRadar : gameweaponObject
	{
		[Ordinal(62)] 
		[RED("colliderComponent")] 
		public CHandle<entIComponent> ColliderComponent
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		[Ordinal(63)] 
		[RED("gameEffectRef")] 
		public gameEffectRef GameEffectRef
		{
			get => GetPropertyValue<gameEffectRef>();
			set => SetPropertyValue<gameEffectRef>(value);
		}

		[Ordinal(64)] 
		[RED("gameEffectInstance")] 
		public CHandle<gameEffectInstance> GameEffectInstance
		{
			get => GetPropertyValue<CHandle<gameEffectInstance>>();
			set => SetPropertyValue<CHandle<gameEffectInstance>>(value);
		}

		[Ordinal(65)] 
		[RED("jammedSensorsArray")] 
		public CArray<CWeakHandle<SensorDevice>> JammedSensorsArray
		{
			get => GetPropertyValue<CArray<CWeakHandle<SensorDevice>>>();
			set => SetPropertyValue<CArray<CWeakHandle<SensorDevice>>>(value);
		}

		public AntiRadar()
		{
			GameEffectRef = new();
			JammedSensorsArray = new();
		}
	}
}
