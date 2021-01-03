using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AICommand : IScriptable
	{
		[Ordinal(0)]  [RED("category")] public CName Category { get; set; }
		[Ordinal(1)]  [RED("id")] public CUInt32 Id { get; set; }
		[Ordinal(2)]  [RED("questBlockId")] public CUInt64 QuestBlockId { get; set; }
		[Ordinal(3)]  [RED("state")] public CEnum<AICommandState> State { get; set; }

		public AICommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
