using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIGateSignalSender : AIbehaviortaskStackScript
	{
		[Ordinal(0)]  [RED("flags")] public CArray<CEnum<EAIGateSignalFlags>> Flags { get; set; }
		[Ordinal(1)]  [RED("priority")] public CFloat Priority { get; set; }
		[Ordinal(2)]  [RED("tags")] public CArray<CName> Tags { get; set; }

		public AIGateSignalSender(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
