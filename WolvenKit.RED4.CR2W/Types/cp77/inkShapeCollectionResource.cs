using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkShapeCollectionResource : CResource
	{
		[Ordinal(1)] [RED("presets")] public CArray<inkShapePreset> Presets { get; set; }

		public inkShapeCollectionResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
