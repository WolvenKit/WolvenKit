using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HealthConsumable : gameCpoPickableItem
	{
		[Ordinal(0)]  [RED("disappearAfterEquip")] public CBool DisappearAfterEquip { get; set; }
		[Ordinal(1)]  [RED("interactionComponent")] public CHandle<gameinteractionsComponent> InteractionComponent { get; set; }
		[Ordinal(2)]  [RED("meshComponent")] public CHandle<entMeshComponent> MeshComponent { get; set; }
		[Ordinal(3)]  [RED("respawnTime")] public CFloat RespawnTime { get; set; }

		public HealthConsumable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
