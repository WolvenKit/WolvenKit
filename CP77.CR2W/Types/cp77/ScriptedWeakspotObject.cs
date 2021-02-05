using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ScriptedWeakspotObject : gameWeakspotObject
	{
		[Ordinal(31)]  [RED("weakspotOnDestroyProperties")] public WeakspotOnDestroyProperties WeakspotOnDestroyProperties { get; set; }
		[Ordinal(32)]  [RED("mesh")] public CHandle<entMeshComponent> Mesh { get; set; }
		[Ordinal(33)]  [RED("interaction")] public CHandle<gameinteractionsComponent> Interaction { get; set; }
		[Ordinal(34)]  [RED("collider")] public CHandle<entIPlacedComponent> Collider { get; set; }
		[Ordinal(35)]  [RED("instigator")] public wCHandle<gameObject> Instigator { get; set; }
		[Ordinal(36)]  [RED("weakspotRecordData")] public WeakspotRecordData WeakspotRecordData { get; set; }
		[Ordinal(37)]  [RED("alive")] public CBool Alive { get; set; }
		[Ordinal(38)]  [RED("hasBeenScanned")] public CBool HasBeenScanned { get; set; }

		public ScriptedWeakspotObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
