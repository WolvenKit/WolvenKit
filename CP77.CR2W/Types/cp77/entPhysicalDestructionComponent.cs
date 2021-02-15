using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entPhysicalDestructionComponent : entIVisualComponent
	{
		[Ordinal(8)] [RED("mesh")] public raRef<CMesh> Mesh { get; set; }
		[Ordinal(9)] [RED("meshAppearance")] public CName MeshAppearance { get; set; }
		[Ordinal(10)] [RED("forceAutoHideDistance")] public CFloat ForceAutoHideDistance { get; set; }
		[Ordinal(11)] [RED("destructionParams")] public physicsDestructionParams DestructionParams { get; set; }
		[Ordinal(12)] [RED("destructionLevelData")] public CArray<physicsDestructionLevelData> DestructionLevelData { get; set; }
		[Ordinal(13)] [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(14)] [RED("audioMetadata")] public CName AudioMetadata { get; set; }

		public entPhysicalDestructionComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
