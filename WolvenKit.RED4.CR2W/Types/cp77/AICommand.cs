using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICommand : IScriptable
	{
		[Ordinal(0)] [RED("id")] public CUInt32 Id { get; set; }
		[Ordinal(1)] [RED("state")] public CEnum<AICommandState> State { get; set; }
		[Ordinal(2)] [RED("questBlockId")] public CUInt64 QuestBlockId { get; set; }
		[Ordinal(3)] [RED("category")] public CName Category { get; set; }

		public AICommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
