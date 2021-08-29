using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CameraTagEnemyLimitDataModule : GameSessionDataModule
	{
		private CInt32 _cameraLimit;
		private CArray<CWeakHandle<SurveillanceCamera>> _cameraList;

		[Ordinal(1)] 
		[RED("cameraLimit")] 
		public CInt32 CameraLimit
		{
			get => GetProperty(ref _cameraLimit);
			set => SetProperty(ref _cameraLimit, value);
		}

		[Ordinal(2)] 
		[RED("cameraList")] 
		public CArray<CWeakHandle<SurveillanceCamera>> CameraList
		{
			get => GetProperty(ref _cameraList);
			set => SetProperty(ref _cameraList, value);
		}
	}
}
