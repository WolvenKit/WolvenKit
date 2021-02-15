using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class physicsICollider : ISerializable
	{
		[Ordinal(0)] [RED("localToBody")] public Transform LocalToBody { get; set; }
		[Ordinal(1)] [RED("material")] public CName Material { get; set; }
		[Ordinal(2)] [RED("materialApperanceOverrides")] public CArray<physicsApperanceMaterial> MaterialApperanceOverrides { get; set; }
		[Ordinal(3)] [RED("tag")] public CName Tag { get; set; }
		[Ordinal(4)] [RED("isImported")] public CBool IsImported { get; set; }
		[Ordinal(5)] [RED("isQueryShapeOnly")] public CBool IsQueryShapeOnly { get; set; }
		[Ordinal(6)] [RED("volumeModifier")] public CFloat VolumeModifier { get; set; }
		[Ordinal(7)] [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }

		public physicsICollider(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
