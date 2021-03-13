using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendorComponent : gameScriptableComponent
	{
		[Ordinal(5)] [RED("vendorTweakID")] public TweakDBID VendorTweakID { get; set; }
		[Ordinal(6)] [RED("junkItemArray")] public CArray<JunkItemRecord> JunkItemArray { get; set; }
		[Ordinal(7)] [RED("brandProcessingSFX")] public CName BrandProcessingSFX { get; set; }
		[Ordinal(8)] [RED("itemFallSFX")] public CName ItemFallSFX { get; set; }

		public VendorComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
