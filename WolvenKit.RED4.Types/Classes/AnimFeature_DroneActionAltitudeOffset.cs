using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_DroneActionAltitudeOffset : animAnimFeature
	{
		private CFloat _desiredOffset;

		[Ordinal(0)] 
		[RED("desiredOffset")] 
		public CFloat DesiredOffset
		{
			get => GetProperty(ref _desiredOffset);
			set => SetProperty(ref _desiredOffset, value);
		}
	}
}
