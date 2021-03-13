using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleUIAnchorButton : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("anchorLocation")] public CEnum<inkEAnchor> AnchorLocation { get; set; }

		public sampleUIAnchorButton(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
