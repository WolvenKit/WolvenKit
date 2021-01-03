using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkShapeCollectionResource : CResource
	{
		[Ordinal(0)]  [RED("presets")] public CArray<inkShapePreset> Presets { get; set; }

		public inkShapeCollectionResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
