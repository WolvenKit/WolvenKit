using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WallScreen : TV
	{
		[Ordinal(102)] [RED("movementPattern")] public SMovementPattern MovementPattern { get; set; }
		[Ordinal(103)] [RED("factOnFullyOpened")] public CName FactOnFullyOpened { get; set; }
		[Ordinal(104)] [RED("objectMover")] public CHandle<ObjectMoverComponent> ObjectMover { get; set; }

		public WallScreen(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
