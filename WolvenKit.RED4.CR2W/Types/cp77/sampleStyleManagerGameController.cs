using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleStyleManagerGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("stylePath1")] public redResourceReferenceScriptToken StylePath1 { get; set; }
		[Ordinal(3)] [RED("stylePath2")] public redResourceReferenceScriptToken StylePath2 { get; set; }
		[Ordinal(4)] [RED("content")] public inkWidgetReference Content { get; set; }

		public sampleStyleManagerGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
