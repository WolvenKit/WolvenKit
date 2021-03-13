using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HoldPositionCommandTask : AIbehaviortaskScript
	{
		[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
		[Ordinal(1)] [RED("currentCommand")] public wCHandle<AIHoldPositionCommand> CurrentCommand { get; set; }
		[Ordinal(2)] [RED("activationTimeStamp")] public CFloat ActivationTimeStamp { get; set; }
		[Ordinal(3)] [RED("commandDuration")] public CFloat CommandDuration { get; set; }

		public HoldPositionCommandTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
