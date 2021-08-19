using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WallScreen : TV
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

		public WallScreen(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
