using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkSingleDrawMetric : CVariable
	{
		[Ordinal(0)]  [RED("exeedsLimit")] public CBool ExeedsLimit { get; set; }
		[Ordinal(1)]  [RED("hierarchySize")] public Vector2 HierarchySize { get; set; }
		[Ordinal(2)]  [RED("usedTextures")] public CArray<CUInt32> UsedTextures { get; set; }

		public inkSingleDrawMetric(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
