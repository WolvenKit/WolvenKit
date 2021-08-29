using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIMoveRotateToCommandHandler : AICommandHandlerBase
	{
		private CHandle<AIArgumentMapping> _target;
		private CHandle<AIArgumentMapping> _angleTolerance;
		private CHandle<AIArgumentMapping> _angleOffset;
		private CHandle<AIArgumentMapping> _speed;

		[Ordinal(1)] 
		[RED("target")] 
		public CHandle<AIArgumentMapping> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(2)] 
		[RED("angleTolerance")] 
		public CHandle<AIArgumentMapping> AngleTolerance
		{
			get => GetProperty(ref _angleTolerance);
			set => SetProperty(ref _angleTolerance, value);
		}

		[Ordinal(3)] 
		[RED("angleOffset")] 
		public CHandle<AIArgumentMapping> AngleOffset
		{
			get => GetProperty(ref _angleOffset);
			set => SetProperty(ref _angleOffset, value);
		}

		[Ordinal(4)] 
		[RED("speed")] 
		public CHandle<AIArgumentMapping> Speed
		{
			get => GetProperty(ref _speed);
			set => SetProperty(ref _speed, value);
		}
	}
}
