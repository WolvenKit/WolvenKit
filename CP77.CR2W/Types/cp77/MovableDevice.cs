using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class MovableDevice : InteractiveDevice
	{
		[Ordinal(0)]  [RED("UseWorkspotComponentPosition")] public CBool UseWorkspotComponentPosition { get; set; }
		[Ordinal(1)]  [RED("additionalMeshComponent")] public CHandle<entMeshComponent> AdditionalMeshComponent { get; set; }
		[Ordinal(2)]  [RED("offMeshConnectionsToOpen")] public CArray<CHandle<AIOffMeshConnectionComponent>> OffMeshConnectionsToOpen { get; set; }
		[Ordinal(3)]  [RED("offMeshConnectionsToOpenNames")] public CArray<CName> OffMeshConnectionsToOpenNames { get; set; }
		[Ordinal(4)]  [RED("shouldMoveRight")] public CBool ShouldMoveRight { get; set; }
		[Ordinal(5)]  [RED("sideTriggerNames")] public CArray<CName> SideTriggerNames { get; set; }
		[Ordinal(6)]  [RED("triggerComponents")] public CArray<CHandle<gameStaticTriggerAreaComponent>> TriggerComponents { get; set; }
		[Ordinal(7)]  [RED("workspotSideName")] public CName WorkspotSideName { get; set; }

		public MovableDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
