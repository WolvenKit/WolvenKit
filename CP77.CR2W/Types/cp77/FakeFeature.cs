using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FakeFeature : gameObject
	{
		[Ordinal(31)]  [RED("choices")] public CArray<SFakeFeatureChoice> Choices { get; set; }
		[Ordinal(32)]  [RED("interaction")] public CHandle<gameinteractionsComponent> Interaction { get; set; }
		[Ordinal(33)]  [RED("components")] public CArray<CHandle<entIPlacedComponent>> Components { get; set; }
		[Ordinal(34)]  [RED("scaningComponent")] public CHandle<gameScanningComponent> ScaningComponent { get; set; }
		[Ordinal(35)]  [RED("was_used")] public CBool Was_used { get; set; }

		public FakeFeature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
