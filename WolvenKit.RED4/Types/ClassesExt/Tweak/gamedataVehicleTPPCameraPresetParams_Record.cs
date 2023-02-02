
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleTPPCameraPresetParams_Record
	{
		[RED("airFlowDistortionSizeHorizontal")]
		[REDProperty(IsIgnored = true)]
		public CFloat AirFlowDistortionSizeHorizontal
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("airFlowDistortionSizeVertical")]
		[REDProperty(IsIgnored = true)]
		public CFloat AirFlowDistortionSizeVertical
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("airFlowDistortionSpeedMax")]
		[REDProperty(IsIgnored = true)]
		public CFloat AirFlowDistortionSpeedMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("airFlowDistortionSpeedMin")]
		[REDProperty(IsIgnored = true)]
		public CFloat AirFlowDistortionSpeedMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("boomLength")]
		[REDProperty(IsIgnored = true)]
		public CFloat BoomLength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("defaultRotationPitch")]
		[REDProperty(IsIgnored = true)]
		public CFloat DefaultRotationPitch
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("distance")]
		[REDProperty(IsIgnored = true)]
		public CName Distance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("height")]
		[REDProperty(IsIgnored = true)]
		public CName Height
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("lookAtOffset")]
		[REDProperty(IsIgnored = true)]
		public Vector3 LookAtOffset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
	}
}
