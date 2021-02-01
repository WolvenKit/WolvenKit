using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ChestPress : InteractiveDevice
	{
		[Ordinal(0)]  [RED("animFeatureData")] public CHandle<AnimFeature_ChestPress> AnimFeatureData { get; set; }
		[Ordinal(1)]  [RED("animFeatureDataName")] public CName AnimFeatureDataName { get; set; }

		public ChestPress(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
