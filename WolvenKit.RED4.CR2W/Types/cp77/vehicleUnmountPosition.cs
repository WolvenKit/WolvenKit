using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleUnmountPosition : CVariable
	{
		private CEnum<vehicleExitDirection> _direction;
		private WorldPosition _position;

		[Ordinal(0)] 
		[RED("direction")] 
		public CEnum<vehicleExitDirection> Direction
		{
			get => GetProperty(ref _direction);
			set => SetProperty(ref _direction, value);
		}

		[Ordinal(1)] 
		[RED("position")] 
		public WorldPosition Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		public vehicleUnmountPosition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
