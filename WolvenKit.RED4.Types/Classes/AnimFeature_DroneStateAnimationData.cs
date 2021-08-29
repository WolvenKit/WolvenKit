using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_DroneStateAnimationData : animAnimFeature
	{
		private CInt32 _statePose;

		[Ordinal(0)] 
		[RED("statePose")] 
		public CInt32 StatePose
		{
			get => GetProperty(ref _statePose);
			set => SetProperty(ref _statePose, value);
		}
	}
}
