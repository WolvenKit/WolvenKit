using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTargetingLocalizedEffectComponent : entIComponent
	{
		private CFloat _streamingDistance;
		private CFloat _visibleTargetRange;

		[Ordinal(3)] 
		[RED("streamingDistance")] 
		public CFloat StreamingDistance
		{
			get => GetProperty(ref _streamingDistance);
			set => SetProperty(ref _streamingDistance, value);
		}

		[Ordinal(4)] 
		[RED("visibleTargetRange")] 
		public CFloat VisibleTargetRange
		{
			get => GetProperty(ref _visibleTargetRange);
			set => SetProperty(ref _visibleTargetRange, value);
		}

		public gameTargetingLocalizedEffectComponent()
		{
			_streamingDistance = 50.000000F;
			_visibleTargetRange = -1.000000F;
		}
	}
}
