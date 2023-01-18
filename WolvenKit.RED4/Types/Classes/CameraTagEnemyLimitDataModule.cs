using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CameraTagEnemyLimitDataModule : GameSessionDataModule
	{
		[Ordinal(1)] 
		[RED("cameraLimit")] 
		public CInt32 CameraLimit
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("cameraList")] 
		public CArray<CWeakHandle<SurveillanceCamera>> CameraList
		{
			get => GetPropertyValue<CArray<CWeakHandle<SurveillanceCamera>>>();
			set => SetPropertyValue<CArray<CWeakHandle<SurveillanceCamera>>>(value);
		}

		public CameraTagEnemyLimitDataModule()
		{
			CameraLimit = 5;
			CameraList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
