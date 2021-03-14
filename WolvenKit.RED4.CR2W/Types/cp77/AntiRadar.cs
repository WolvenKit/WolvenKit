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

		[Ordinal(57)] 
		[RED("colliderComponent")] 
		public CHandle<entIComponent> ColliderComponent
		{
			get
			{
				if (_colliderComponent == null)
				{
					_colliderComponent = (CHandle<entIComponent>) CR2WTypeManager.Create("handle:entIComponent", "colliderComponent", cr2w, this);
				}
				return _colliderComponent;
			}
			set
			{
				if (_colliderComponent == value)
				{
					return;
				}
				_colliderComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(58)] 
		[RED("gameEffectRef")] 
		public gameEffectRef GameEffectRef
		{
			get
			{
				if (_gameEffectRef == null)
				{
					_gameEffectRef = (gameEffectRef) CR2WTypeManager.Create("gameEffectRef", "gameEffectRef", cr2w, this);
				}
				return _gameEffectRef;
			}
			set
			{
				if (_gameEffectRef == value)
				{
					return;
				}
				_gameEffectRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(59)] 
		[RED("gameEffectInstance")] 
		public CHandle<gameEffectInstance> GameEffectInstance
		{
			get
			{
				if (_gameEffectInstance == null)
				{
					_gameEffectInstance = (CHandle<gameEffectInstance>) CR2WTypeManager.Create("handle:gameEffectInstance", "gameEffectInstance", cr2w, this);
				}
				return _gameEffectInstance;
			}
			set
			{
				if (_gameEffectInstance == value)
				{
					return;
				}
				_gameEffectInstance = value;
				PropertySet(this);
			}
		}

		[Ordinal(60)] 
		[RED("jammedSensorsArray")] 
		public CArray<wCHandle<SensorDevice>> JammedSensorsArray
		{
			get
			{
				if (_jammedSensorsArray == null)
				{
					_jammedSensorsArray = (CArray<wCHandle<SensorDevice>>) CR2WTypeManager.Create("array:whandle:SensorDevice", "jammedSensorsArray", cr2w, this);
				}
				return _jammedSensorsArray;
			}
			set
			{
				if (_jammedSensorsArray == value)
				{
					return;
				}
				_jammedSensorsArray = value;
				PropertySet(this);
			}
		}

		public AntiRadar(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
