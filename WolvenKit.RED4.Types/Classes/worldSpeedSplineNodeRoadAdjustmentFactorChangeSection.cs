using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldSpeedSplineNodeRoadAdjustmentFactorChangeSection : RedBaseClass
	{
		private CFloat _pos;
		private CFloat _targetFactor;

		[Ordinal(0)] 
		[RED("pos")] 
		public CFloat Pos
		{
			get => GetProperty(ref _pos);
			set => SetProperty(ref _pos, value);
		}

		[Ordinal(1)] 
		[RED("targetFactor")] 
		public CFloat TargetFactor
		{
			get => GetProperty(ref _targetFactor);
			set => SetProperty(ref _targetFactor, value);
		}

		public worldSpeedSplineNodeRoadAdjustmentFactorChangeSection()
		{
			_targetFactor = 1.000000F;
		}
	}
}
