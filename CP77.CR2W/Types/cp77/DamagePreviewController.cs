using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DamagePreviewController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("fullBar")] public inkWidgetReference FullBar { get; set; }
		[Ordinal(2)] [RED("stippedBar")] public inkWidgetReference StippedBar { get; set; }
		[Ordinal(3)] [RED("rootCanvas")] public inkWidgetReference RootCanvas { get; set; }
		[Ordinal(4)] [RED("width")] public CFloat Width { get; set; }
		[Ordinal(5)] [RED("height")] public CFloat Height { get; set; }
		[Ordinal(6)] [RED("heightStripped")] public CFloat HeightStripped { get; set; }
		[Ordinal(7)] [RED("heightRoot")] public CFloat HeightRoot { get; set; }
		[Ordinal(8)] [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }

		public DamagePreviewController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
