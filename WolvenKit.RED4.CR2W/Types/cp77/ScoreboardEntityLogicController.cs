using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScoreboardEntityLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("label")] public inkTextWidgetReference Label { get; set; }

		public ScoreboardEntityLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
