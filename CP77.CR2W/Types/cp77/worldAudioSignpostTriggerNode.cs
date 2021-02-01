using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldAudioSignpostTriggerNode : worldTriggerAreaNode
	{
		[Ordinal(0)]  [RED("enterSignpost")] public CName EnterSignpost { get; set; }
		[Ordinal(1)]  [RED("exitCooldown")] public CFloat ExitCooldown { get; set; }
		[Ordinal(2)]  [RED("exitSignpost")] public CName ExitSignpost { get; set; }

		public worldAudioSignpostTriggerNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
