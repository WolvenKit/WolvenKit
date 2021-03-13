using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleTransitionInitData : IScriptable
	{
		[Ordinal(0)] [RED("instant")] public CBool Instant { get; set; }
		[Ordinal(1)] [RED("entityID")] public entEntityID EntityID { get; set; }
		[Ordinal(2)] [RED("alive")] public CBool Alive { get; set; }
		[Ordinal(3)] [RED("occupiedByNeutral")] public CBool OccupiedByNeutral { get; set; }

		public VehicleTransitionInitData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
