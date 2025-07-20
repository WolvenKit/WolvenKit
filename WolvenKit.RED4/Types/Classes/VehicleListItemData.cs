using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleListItemData : IScriptable
	{
		[Ordinal(0)] 
		[RED("displayName")] 
		public CName DisplayName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("data")] 
		public vehiclePlayerVehicle Data
		{
			get => GetPropertyValue<vehiclePlayerVehicle>();
			set => SetPropertyValue<vehiclePlayerVehicle>(value);
		}

		[Ordinal(2)] 
		[RED("icon")] 
		public CWeakHandle<gamedataUIIcon_Record> Icon
		{
			get => GetPropertyValue<CWeakHandle<gamedataUIIcon_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataUIIcon_Record>>(value);
		}

		[Ordinal(3)] 
		[RED("repairTimeRemaining")] 
		public CFloat RepairTimeRemaining
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("canBeActive")] 
		public CBool CanBeActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public VehicleListItemData()
		{
			Data = new vehiclePlayerVehicle { VehicleType = Enums.gamedataVehicleType.Invalid, UiFavoriteIndex = -1, DestructionTimeStamp = new EngineTime() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
