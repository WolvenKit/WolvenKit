using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryTooltipData_CyberdeckData : IScriptable
	{
		[Ordinal(0)] 
		[RED("vehicleHackUnlocked")] 
		public CBool VehicleHackUnlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("viewingTooltipFromCyberwareMenu")] 
		public CBool ViewingTooltipFromCyberwareMenu
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public InventoryTooltipData_CyberdeckData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
