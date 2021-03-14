using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FakeFeature : gameObject
	{
		[Ordinal(40)] [RED("choices")] public CArray<SFakeFeatureChoice> Choices { get; set; }
		[Ordinal(41)] [RED("interaction")] public CHandle<gameinteractionsComponent> Interaction { get; set; }
		[Ordinal(42)] [RED("components")] public CArray<CHandle<entIPlacedComponent>> Components { get; set; }
		[Ordinal(43)] [RED("scaningComponent")] public CHandle<gameScanningComponent> ScaningComponent { get; set; }
		[Ordinal(44)] [RED("was_used")] public CBool Was_used { get; set; }

		public FakeFeature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
