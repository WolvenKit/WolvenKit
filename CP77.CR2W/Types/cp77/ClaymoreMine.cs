using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ClaymoreMine : gameweaponObject
	{
		[Ordinal(0)]  [RED("alive")] public CBool Alive { get; set; }
		[Ordinal(1)]  [RED("armed")] public CBool Armed { get; set; }
		[Ordinal(2)]  [RED("shootCollision")] public CHandle<entSimpleColliderComponent> ShootCollision { get; set; }
		[Ordinal(3)]  [RED("triggerAreaIndicator")] public CHandle<entMeshComponent> TriggerAreaIndicator { get; set; }
		[Ordinal(4)]  [RED("triggerComponent")] public CHandle<gameStaticTriggerAreaComponent> TriggerComponent { get; set; }
		[Ordinal(5)]  [RED("visualComponent")] public CHandle<entMeshComponent> VisualComponent { get; set; }

		public ClaymoreMine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
