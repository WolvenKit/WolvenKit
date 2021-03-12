using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldAudioSignpostTriggerNode : worldTriggerAreaNode
	{
		[Ordinal(7)] [RED("enterSignpost")] public CName EnterSignpost { get; set; }
		[Ordinal(8)] [RED("exitSignpost")] public CName ExitSignpost { get; set; }
		[Ordinal(9)] [RED("exitCooldown")] public CFloat ExitCooldown { get; set; }

		public worldAudioSignpostTriggerNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
