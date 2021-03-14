using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkCacheWidget : inkCompoundWidget
	{
		[Ordinal(23)] [RED("innerScale")] public Vector2 InnerScale { get; set; }
		[Ordinal(24)] [RED("mode")] public CEnum<inkCacheMode> Mode { get; set; }
		[Ordinal(25)] [RED("externalDynamicTexture")] public CName ExternalDynamicTexture { get; set; }

		public inkCacheWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
