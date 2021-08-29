using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimFeature_VehiclePassengerAnimSetup : animAnimFeature
	{
		private CBool _enableAdditiveAnim;
		private CFloat _additiveScale;

		[Ordinal(0)] 
		[RED("enableAdditiveAnim")] 
		public CBool EnableAdditiveAnim
		{
			get => GetProperty(ref _enableAdditiveAnim);
			set => SetProperty(ref _enableAdditiveAnim, value);
		}

		[Ordinal(1)] 
		[RED("additiveScale")] 
		public CFloat AdditiveScale
		{
			get => GetProperty(ref _additiveScale);
			set => SetProperty(ref _additiveScale, value);
		}
	}
}
