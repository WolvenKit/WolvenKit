using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class WeakFence : InteractiveDevice
	{
		[Ordinal(0)]  [RED("currentWorkspotSuffix")] public CName CurrentWorkspotSuffix { get; set; }
		[Ordinal(1)]  [RED("impulseForce")] public CFloat ImpulseForce { get; set; }
		[Ordinal(2)]  [RED("impulseVector")] public Vector4 ImpulseVector { get; set; }
		[Ordinal(3)]  [RED("offMeshConnectionComponent")] public CHandle<AIOffMeshConnectionComponent> OffMeshConnectionComponent { get; set; }
		[Ordinal(4)]  [RED("physicalMesh")] public CHandle<entIPlacedComponent> PhysicalMesh { get; set; }
		[Ordinal(5)]  [RED("sideTriggerNames")] public CArray<CName> SideTriggerNames { get; set; }
		[Ordinal(6)]  [RED("triggerComponents")] public CArray<CHandle<gameStaticTriggerAreaComponent>> TriggerComponents { get; set; }

		public WeakFence(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
