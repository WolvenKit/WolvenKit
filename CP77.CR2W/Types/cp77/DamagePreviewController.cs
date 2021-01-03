using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DamagePreviewController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(1)]  [RED("fullBar")] public inkWidgetReference FullBar { get; set; }
		[Ordinal(2)]  [RED("height")] public CFloat Height { get; set; }
		[Ordinal(3)]  [RED("heightRoot")] public CFloat HeightRoot { get; set; }
		[Ordinal(4)]  [RED("heightStripped")] public CFloat HeightStripped { get; set; }
		[Ordinal(5)]  [RED("rootCanvas")] public inkWidgetReference RootCanvas { get; set; }
		[Ordinal(6)]  [RED("stippedBar")] public inkWidgetReference StippedBar { get; set; }
		[Ordinal(7)]  [RED("width")] public CFloat Width { get; set; }

		public DamagePreviewController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
