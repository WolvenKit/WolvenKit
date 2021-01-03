using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entInstancedAnimationComponent : entISkinableComponent
	{
		[Ordinal(0)]  [RED("animToSample")] public CName AnimToSample { get; set; }
		[Ordinal(1)]  [RED("animations")] public rRef<animAnimSet> Animations { get; set; }
		[Ordinal(2)]  [RED("variantAnimToSample")] public CName VariantAnimToSample { get; set; }
		[Ordinal(3)]  [RED("variantTriggerTag")] public CName VariantTriggerTag { get; set; }

		public entInstancedAnimationComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
