using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questConstAICommandParams : questAICommandParams
	{
		[Ordinal(0)] [RED("command")] public CHandle<AICommand> Command { get; set; }

		public questConstAICommandParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
