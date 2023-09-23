using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AgentBase : IScriptable
	{
		[Ordinal(0)] 
		[RED("id")] 
		public entEntityID Id
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("gameObject")] 
		public CWeakHandle<gameObject> GameObject
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(2)] 
		[RED("spawnedType")] 
		public CEnum<gameDynamicVehicleType> SpawnedType
		{
			get => GetPropertyValue<CEnum<gameDynamicVehicleType>>();
			set => SetPropertyValue<CEnum<gameDynamicVehicleType>>(value);
		}

		public AgentBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
