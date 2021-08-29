using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIRotateToCommand : AIMoveCommand
	{
		private AIPositionSpec _target;
		private CFloat _angleTolerance;
		private CFloat _angleOffset;
		private CFloat _speed;

		[Ordinal(7)] 
		[RED("target")] 
		public AIPositionSpec Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(8)] 
		[RED("angleTolerance")] 
		public CFloat AngleTolerance
		{
			get => GetProperty(ref _angleTolerance);
			set => SetProperty(ref _angleTolerance, value);
		}

		[Ordinal(9)] 
		[RED("angleOffset")] 
		public CFloat AngleOffset
		{
			get => GetProperty(ref _angleOffset);
			set => SetProperty(ref _angleOffset, value);
		}

		[Ordinal(10)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get => GetProperty(ref _speed);
			set => SetProperty(ref _speed, value);
		}
	}
}
