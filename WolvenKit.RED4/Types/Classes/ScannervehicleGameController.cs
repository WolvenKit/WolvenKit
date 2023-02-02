using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannervehicleGameController : BaseChunkGameController
	{
		[Ordinal(5)] 
		[RED("vehicleNameCallbackID")] 
		public CHandle<redCallbackObject> VehicleNameCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(6)] 
		[RED("vehicleManufacturerCallbackID")] 
		public CHandle<redCallbackObject> VehicleManufacturerCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(7)] 
		[RED("vehicleProdYearsCallbackID")] 
		public CHandle<redCallbackObject> VehicleProdYearsCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(8)] 
		[RED("vehicleDriveLayoutCallbackID")] 
		public CHandle<redCallbackObject> VehicleDriveLayoutCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(9)] 
		[RED("vehicleHorsepowerCallbackID")] 
		public CHandle<redCallbackObject> VehicleHorsepowerCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(10)] 
		[RED("vehicleMassCallbackID")] 
		public CHandle<redCallbackObject> VehicleMassCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(11)] 
		[RED("vehicleStateCallbackID")] 
		public CHandle<redCallbackObject> VehicleStateCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(12)] 
		[RED("vehicleInfoCallbackID")] 
		public CHandle<redCallbackObject> VehicleInfoCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(13)] 
		[RED("isValidVehicleManufacturer")] 
		public CBool IsValidVehicleManufacturer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("isValidVehicleName")] 
		public CBool IsValidVehicleName
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("isValidVehicleProdYears")] 
		public CBool IsValidVehicleProdYears
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("isValidVehicleDriveLayout")] 
		public CBool IsValidVehicleDriveLayout
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("isValidVehicleHorsepower")] 
		public CBool IsValidVehicleHorsepower
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("isValidVehicleMass")] 
		public CBool IsValidVehicleMass
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("isValidVehicleState")] 
		public CBool IsValidVehicleState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("isValidVehicleInfo")] 
		public CBool IsValidVehicleInfo
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("vehicleNameText")] 
		public inkTextWidgetReference VehicleNameText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("vehicleManufacturer")] 
		public inkImageWidgetReference VehicleManufacturer
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("vehicleProdYearsText")] 
		public inkTextWidgetReference VehicleProdYearsText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("vehicleDriveLayoutText")] 
		public inkTextWidgetReference VehicleDriveLayoutText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("vehicleHorsepowerText")] 
		public inkTextWidgetReference VehicleHorsepowerText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("vehicleMassText")] 
		public inkTextWidgetReference VehicleMassText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("vehicleStateText")] 
		public inkTextWidgetReference VehicleStateText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("vehicleInfoText")] 
		public inkTextWidgetReference VehicleInfoText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(29)] 
		[RED("vehicleNameHolder")] 
		public inkWidgetReference VehicleNameHolder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("vehicleProdYearsHolder")] 
		public inkWidgetReference VehicleProdYearsHolder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("vehicleDriveLayoutHolder")] 
		public inkWidgetReference VehicleDriveLayoutHolder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(32)] 
		[RED("vehicleHorsepowerHolder")] 
		public inkWidgetReference VehicleHorsepowerHolder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(33)] 
		[RED("vehicleMassHolder")] 
		public inkWidgetReference VehicleMassHolder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(34)] 
		[RED("vehicleStateHolder")] 
		public inkWidgetReference VehicleStateHolder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(35)] 
		[RED("vehicleInfoHolder")] 
		public inkWidgetReference VehicleInfoHolder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public ScannervehicleGameController()
		{
			VehicleNameText = new();
			VehicleManufacturer = new();
			VehicleProdYearsText = new();
			VehicleDriveLayoutText = new();
			VehicleHorsepowerText = new();
			VehicleMassText = new();
			VehicleStateText = new();
			VehicleInfoText = new();
			VehicleNameHolder = new();
			VehicleProdYearsHolder = new();
			VehicleDriveLayoutHolder = new();
			VehicleHorsepowerHolder = new();
			VehicleMassHolder = new();
			VehicleStateHolder = new();
			VehicleInfoHolder = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
