using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiInputHintController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("inputDisplayContainer")] public inkCompoundWidgetReference InputDisplayContainer { get; set; }
		[Ordinal(1)]  [RED("inputDisplayLibRef")] public inkWidgetLibraryReference InputDisplayLibRef { get; set; }
		[Ordinal(2)]  [RED("textWidgetRef")] public inkTextWidgetReference TextWidgetRef { get; set; }

		public gameuiInputHintController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
