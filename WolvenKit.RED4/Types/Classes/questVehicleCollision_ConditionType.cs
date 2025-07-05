using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questVehicleCollision_ConditionType : questIVehicleConditionType
	{
		[Ordinal(0)] 
		[RED("magnitude")] 
		public CEnum<questImpulseMagnitude> Magnitude
		{
			get => GetPropertyValue<CEnum<questImpulseMagnitude>>();
			set => SetPropertyValue<CEnum<questImpulseMagnitude>>(value);
		}

		public questVehicleCollision_ConditionType()
		{
			Magnitude = Enums.questImpulseMagnitude.Medium;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
