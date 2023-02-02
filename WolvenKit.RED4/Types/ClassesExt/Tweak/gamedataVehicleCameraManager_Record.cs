
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleCameraManager_Record
	{
		[RED("allowCameraReset")]
		[REDProperty(IsIgnored = true)]
		public CBool AllowCameraReset
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("camCollisionOBBIncrease")]
		[REDProperty(IsIgnored = true)]
		public Vector3 CamCollisionOBBIncrease
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("cameraBlendTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat CameraBlendTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
