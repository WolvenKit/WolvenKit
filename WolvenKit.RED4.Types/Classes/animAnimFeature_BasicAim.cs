using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimFeature_BasicAim : animAnimFeature
	{
		private CInt32 _aimState;
		private CInt32 _zoomState;

		[Ordinal(0)] 
		[RED("aimState")] 
		public CInt32 AimState
		{
			get => GetProperty(ref _aimState);
			set => SetProperty(ref _aimState, value);
		}

		[Ordinal(1)] 
		[RED("zoomState")] 
		public CInt32 ZoomState
		{
			get => GetProperty(ref _zoomState);
			set => SetProperty(ref _zoomState, value);
		}
	}
}
