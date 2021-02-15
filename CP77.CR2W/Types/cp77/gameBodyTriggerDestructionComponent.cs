using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameBodyTriggerDestructionComponent : entIComponent
	{
		[Ordinal(3)] [RED("colliderComponentName")] public CName ColliderComponentName { get; set; }
		[Ordinal(4)] [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }
		[Ordinal(5)] [RED("impulseForce")] public CFloat ImpulseForce { get; set; }
		[Ordinal(6)] [RED("impulseRadius")] public CFloat ImpulseRadius { get; set; }

		public gameBodyTriggerDestructionComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
