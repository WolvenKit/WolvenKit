using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CarryEvents : CarriedObjectEvents
	{
		[Ordinal(9)] 
		[RED("knockdownImmunityModifier")] 
		public CHandle<gameStatModifierData_Deprecated> KnockdownImmunityModifier
		{
			get => GetPropertyValue<CHandle<gameStatModifierData_Deprecated>>();
			set => SetPropertyValue<CHandle<gameStatModifierData_Deprecated>>(value);
		}

		public CarryEvents()
		{
			StyleName = "CarriedObject.Style";
			ForceStyleName = "CarriedObject.ForcedStyle";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
