using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsMaterialTags : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("aiVisibility")] 
		public CEnum<physicsMaterialTagVisibility> AiVisibility
		{
			get => GetPropertyValue<CEnum<physicsMaterialTagVisibility>>();
			set => SetPropertyValue<CEnum<physicsMaterialTagVisibility>>(value);
		}

		[Ordinal(1)] 
		[RED("playerVisibility")] 
		public CEnum<physicsMaterialTagVisibility> PlayerVisibility
		{
			get => GetPropertyValue<CEnum<physicsMaterialTagVisibility>>();
			set => SetPropertyValue<CEnum<physicsMaterialTagVisibility>>(value);
		}

		[Ordinal(2)] 
		[RED("projectilePenetration")] 
		public CEnum<physicsMaterialTagProjectilePenetration> ProjectilePenetration
		{
			get => GetPropertyValue<CEnum<physicsMaterialTagProjectilePenetration>>();
			set => SetPropertyValue<CEnum<physicsMaterialTagProjectilePenetration>>(value);
		}

		[Ordinal(3)] 
		[RED("projectileRicochet")] 
		public CEnum<physicsMaterialTagProjectileRicochet> ProjectileRicochet
		{
			get => GetPropertyValue<CEnum<physicsMaterialTagProjectileRicochet>>();
			set => SetPropertyValue<CEnum<physicsMaterialTagProjectileRicochet>>(value);
		}

		[Ordinal(4)] 
		[RED("vehicleTraction")] 
		public CEnum<physicsMaterialTagVehicleTraction> VehicleTraction
		{
			get => GetPropertyValue<CEnum<physicsMaterialTagVehicleTraction>>();
			set => SetPropertyValue<CEnum<physicsMaterialTagVehicleTraction>>(value);
		}

		public physicsMaterialTags()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
