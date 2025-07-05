using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UnregisterResult : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("success")] 
		public CBool Success
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("isVehicle")] 
		public CBool IsVehicle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("spawnedType")] 
		public CEnum<gameDynamicVehicleType> SpawnedType
		{
			get => GetPropertyValue<CEnum<gameDynamicVehicleType>>();
			set => SetPropertyValue<CEnum<gameDynamicVehicleType>>(value);
		}

		public UnregisterResult()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
