using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AntiRadar : gameweaponObject
	{
		private CHandle<entIComponent> _colliderComponent;
		private gameEffectRef _gameEffectRef;
		private CHandle<gameEffectInstance> _gameEffectInstance;
		private CArray<CWeakHandle<SensorDevice>> _jammedSensorsArray;

		[Ordinal(62)] 
		[RED("colliderComponent")] 
		public CHandle<entIComponent> ColliderComponent
		{
			get => GetProperty(ref _colliderComponent);
			set => SetProperty(ref _colliderComponent, value);
		}

		[Ordinal(63)] 
		[RED("gameEffectRef")] 
		public gameEffectRef GameEffectRef
		{
			get => GetProperty(ref _gameEffectRef);
			set => SetProperty(ref _gameEffectRef, value);
		}

		[Ordinal(64)] 
		[RED("gameEffectInstance")] 
		public CHandle<gameEffectInstance> GameEffectInstance
		{
			get => GetProperty(ref _gameEffectInstance);
			set => SetProperty(ref _gameEffectInstance, value);
		}

		[Ordinal(65)] 
		[RED("jammedSensorsArray")] 
		public CArray<CWeakHandle<SensorDevice>> JammedSensorsArray
		{
			get => GetProperty(ref _jammedSensorsArray);
			set => SetProperty(ref _jammedSensorsArray, value);
		}
	}
}
