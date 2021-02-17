using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ScriptedWeakspotObject : gameWeakspotObject
	{
		[Ordinal(40)] [RED("weakspotOnDestroyProperties")] public WeakspotOnDestroyProperties WeakspotOnDestroyProperties { get; set; }
		[Ordinal(41)] [RED("mesh")] public CHandle<entMeshComponent> Mesh { get; set; }
		[Ordinal(42)] [RED("interaction")] public CHandle<gameinteractionsComponent> Interaction { get; set; }
		[Ordinal(43)] [RED("collider")] public CHandle<entIPlacedComponent> Collider { get; set; }
		[Ordinal(44)] [RED("instigator")] public wCHandle<gameObject> Instigator { get; set; }
		[Ordinal(45)] [RED("weakspotRecordData")] public WeakspotRecordData WeakspotRecordData { get; set; }
		[Ordinal(46)] [RED("alive")] public CBool Alive { get; set; }
		[Ordinal(47)] [RED("hasBeenScanned")] public CBool HasBeenScanned { get; set; }

		public ScriptedWeakspotObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
