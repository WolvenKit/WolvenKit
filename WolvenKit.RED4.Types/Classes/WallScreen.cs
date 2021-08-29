using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WallScreen : TV
	{
		private SMovementPattern _movementPattern;
		private CName _factOnFullyOpened;
		private CHandle<ObjectMoverComponent> _objectMover;

		[Ordinal(106)] 
		[RED("movementPattern")] 
		public SMovementPattern MovementPattern
		{
			get => GetProperty(ref _movementPattern);
			set => SetProperty(ref _movementPattern, value);
		}

		[Ordinal(107)] 
		[RED("factOnFullyOpened")] 
		public CName FactOnFullyOpened
		{
			get => GetProperty(ref _factOnFullyOpened);
			set => SetProperty(ref _factOnFullyOpened, value);
		}

		[Ordinal(108)] 
		[RED("objectMover")] 
		public CHandle<ObjectMoverComponent> ObjectMover
		{
			get => GetProperty(ref _objectMover);
			set => SetProperty(ref _objectMover, value);
		}
	}
}
