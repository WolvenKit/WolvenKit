using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetVehicleCamera_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)] 
		[RED("cameraType")] 
		public CEnum<questVehicleCameraType> CameraType
		{
			get => GetPropertyValue<CEnum<questVehicleCameraType>>();
			set => SetPropertyValue<CEnum<questVehicleCameraType>>(value);
		}

		[Ordinal(1)] 
		[RED("blockOtherCameras")] 
		public CBool BlockOtherCameras
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questSetVehicleCamera_NodeType()
		{
			CameraType = Enums.questVehicleCameraType.PuppetFPP;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
