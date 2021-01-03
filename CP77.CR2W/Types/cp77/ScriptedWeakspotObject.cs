using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ScriptedWeakspotObject : gameWeakspotObject
	{
		[Ordinal(0)]  [RED("alive")] public CBool Alive { get; set; }
		[Ordinal(1)]  [RED("collider")] public CHandle<entIPlacedComponent> Collider { get; set; }
		[Ordinal(2)]  [RED("hasBeenScanned")] public CBool HasBeenScanned { get; set; }
		[Ordinal(3)]  [RED("instigator")] public wCHandle<gameObject> Instigator { get; set; }
		[Ordinal(4)]  [RED("interaction")] public CHandle<gameinteractionsComponent> Interaction { get; set; }
		[Ordinal(5)]  [RED("mesh")] public CHandle<entMeshComponent> Mesh { get; set; }
		[Ordinal(6)]  [RED("weakspotOnDestroyProperties")] public WeakspotOnDestroyProperties WeakspotOnDestroyProperties { get; set; }
		[Ordinal(7)]  [RED("weakspotRecordData")] public WeakspotRecordData WeakspotRecordData { get; set; }

		public ScriptedWeakspotObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
