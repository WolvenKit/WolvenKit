using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleRadioLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("isSoundStopped")] public CBool IsSoundStopped { get; set; }

		public VehicleRadioLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
