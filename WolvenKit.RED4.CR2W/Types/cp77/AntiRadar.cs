using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AntiRadar : gameweaponObject
	{
		private CHandle<entIComponent> _colliderComponent;
		private gameEffectRef _gameEffectRef;
		private CHandle<gameEffectInstance> _gameEffectInstance;
		private CArray<wCHandle<SensorDevice>> _jammedSensorsArray;

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
		public CArray<wCHandle<SensorDevice>> JammedSensorsArray
		{
			get => GetProperty(ref _jammedSensorsArray);
			set => SetProperty(ref _jammedSensorsArray, value);
		}

		public AntiRadar(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
