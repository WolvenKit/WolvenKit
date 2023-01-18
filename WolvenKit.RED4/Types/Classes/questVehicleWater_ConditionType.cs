using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questVehicleWater_ConditionType : questIVehicleConditionType
	{
		[Ordinal(0)] 
		[RED("submergedOnly")] 
		public CBool SubmergedOnly
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("onEnter")] 
		public CBool OnEnter
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questVehicleWater_ConditionType()
		{
			SubmergedOnly = true;
			OnEnter = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
