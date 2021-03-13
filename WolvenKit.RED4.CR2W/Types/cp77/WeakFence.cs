using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WeakFence : InteractiveDevice
	{
		[Ordinal(93)] [RED("impulseForce")] public CFloat ImpulseForce { get; set; }
		[Ordinal(94)] [RED("impulseVector")] public Vector4 ImpulseVector { get; set; }
		[Ordinal(95)] [RED("sideTriggerNames")] public CArray<CName> SideTriggerNames { get; set; }
		[Ordinal(96)] [RED("triggerComponents")] public CArray<CHandle<gameStaticTriggerAreaComponent>> TriggerComponents { get; set; }
		[Ordinal(97)] [RED("currentWorkspotSuffix")] public CName CurrentWorkspotSuffix { get; set; }
		[Ordinal(98)] [RED("offMeshConnectionComponent")] public CHandle<AIOffMeshConnectionComponent> OffMeshConnectionComponent { get; set; }
		[Ordinal(99)] [RED("physicalMesh")] public CHandle<entIPlacedComponent> PhysicalMesh { get; set; }

		public WeakFence(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
