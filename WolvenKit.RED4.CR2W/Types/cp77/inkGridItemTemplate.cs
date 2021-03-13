using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkGridItemTemplate : CVariable
	{
		[Ordinal(0)] [RED("sizeX")] public CUInt32 SizeX { get; set; }
		[Ordinal(1)] [RED("sizeY")] public CUInt32 SizeY { get; set; }
		[Ordinal(2)] [RED("widget")] public inkWidgetLibraryReference Widget { get; set; }

		public inkGridItemTemplate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
