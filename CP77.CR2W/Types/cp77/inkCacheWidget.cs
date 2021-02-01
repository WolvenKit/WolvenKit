using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkCacheWidget : inkCompoundWidget
	{
		[Ordinal(0)]  [RED("externalDynamicTexture")] public CName ExternalDynamicTexture { get; set; }
		[Ordinal(1)]  [RED("innerScale")] public Vector2 InnerScale { get; set; }
		[Ordinal(2)]  [RED("mode")] public CEnum<inkCacheMode> Mode { get; set; }

		public inkCacheWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
