using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ShootCommandTask : AIbehaviortaskScript
	{
		[Ordinal(0)]  [RED("activationTimeStamp")] public CFloat ActivationTimeStamp { get; set; }
		[Ordinal(1)]  [RED("commandDuration")] public CFloat CommandDuration { get; set; }
		[Ordinal(2)]  [RED("currentCommand")] public wCHandle<AIShootCommand> CurrentCommand { get; set; }
		[Ordinal(3)]  [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
		[Ordinal(4)]  [RED("target")] public wCHandle<gameObject> Target { get; set; }
		[Ordinal(5)]  [RED("targetID")] public entEntityID TargetID { get; set; }

		public ShootCommandTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
