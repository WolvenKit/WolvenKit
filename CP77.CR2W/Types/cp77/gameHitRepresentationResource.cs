using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameHitRepresentationResource : CResource
	{
		[Ordinal(0)]  [RED("overrides")] public CArray<gameHitRepresentationVisualTaggedOverride> Overrides { get; set; }
		[Ordinal(1)]  [RED("representations")] public CArray<gameHitShapeContainer> Representations { get; set; }

		public gameHitRepresentationResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
