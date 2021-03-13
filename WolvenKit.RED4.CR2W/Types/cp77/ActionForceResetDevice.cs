using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActionForceResetDevice : ActionBool
	{
		[Ordinal(25)] [RED("restartDuration")] public CInt32 RestartDuration { get; set; }

		public ActionForceResetDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
