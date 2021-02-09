using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WeakFence : InteractiveDevice
	{
		[Ordinal(84)]  [RED("impulseForce")] public CFloat ImpulseForce { get; set; }
		[Ordinal(85)]  [RED("impulseVector")] public Vector4 ImpulseVector { get; set; }
		[Ordinal(86)]  [RED("sideTriggerNames")] public CArray<CName> SideTriggerNames { get; set; }
		[Ordinal(87)]  [RED("triggerComponents")] public CArray<CHandle<gameStaticTriggerAreaComponent>> TriggerComponents { get; set; }
		[Ordinal(88)]  [RED("currentWorkspotSuffix")] public CName CurrentWorkspotSuffix { get; set; }
		[Ordinal(89)]  [RED("offMeshConnectionComponent")] public CHandle<AIOffMeshConnectionComponent> OffMeshConnectionComponent { get; set; }
		[Ordinal(90)]  [RED("physicalMesh")] public CHandle<entIPlacedComponent> PhysicalMesh { get; set; }

		public WeakFence(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
