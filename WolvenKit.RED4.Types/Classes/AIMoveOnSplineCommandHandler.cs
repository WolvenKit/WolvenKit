using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIMoveOnSplineCommandHandler : AICommandHandlerBase
	{
		private CHandle<AIArgumentMapping> _outSpline;
		private CHandle<AIArgumentMapping> _outMovementType;
		private CHandle<AIArgumentMapping> _outRotateTowardsFacingTarget;
		private CHandle<AIArgumentMapping> _outFacingTarget;
		private CHandle<AIArgumentMapping> _outSnapToTerrain;

		[Ordinal(1)] 
		[RED("outSpline")] 
		public CHandle<AIArgumentMapping> OutSpline
		{
			get => GetProperty(ref _outSpline);
			set => SetProperty(ref _outSpline, value);
		}

		[Ordinal(2)] 
		[RED("outMovementType")] 
		public CHandle<AIArgumentMapping> OutMovementType
		{
			get => GetProperty(ref _outMovementType);
			set => SetProperty(ref _outMovementType, value);
		}

		[Ordinal(3)] 
		[RED("outRotateTowardsFacingTarget")] 
		public CHandle<AIArgumentMapping> OutRotateTowardsFacingTarget
		{
			get => GetProperty(ref _outRotateTowardsFacingTarget);
			set => SetProperty(ref _outRotateTowardsFacingTarget, value);
		}

		[Ordinal(4)] 
		[RED("outFacingTarget")] 
		public CHandle<AIArgumentMapping> OutFacingTarget
		{
			get => GetProperty(ref _outFacingTarget);
			set => SetProperty(ref _outFacingTarget, value);
		}

		[Ordinal(5)] 
		[RED("outSnapToTerrain")] 
		public CHandle<AIArgumentMapping> OutSnapToTerrain
		{
			get => GetProperty(ref _outSnapToTerrain);
			set => SetProperty(ref _outSnapToTerrain, value);
		}
	}
}
