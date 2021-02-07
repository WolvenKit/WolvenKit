using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entVisualControllerComponent : entIComponent
	{
		[Ordinal(0)]  [RED("meshProxy")] public rRef<CMesh> MeshProxy { get; set; }
		[Ordinal(1)]  [RED("appearanceDependency")] public CArray<entVisualControllerDependency> AppearanceDependency { get; set; }
		[Ordinal(2)]  [RED("cookedAppearanceData")] public raRef<appearanceCookedAppearanceData> CookedAppearanceData { get; set; }
		[Ordinal(3)]  [RED("forcedLodDistance")] public CEnum<entVisualControllerComponentForcedLodDistance> ForcedLodDistance { get; set; }

		public entVisualControllerComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
