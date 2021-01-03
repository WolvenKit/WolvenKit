using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIGateSignal : CVariable
	{
		[Ordinal(0)]  [RED("flags")] public CEnum<AISignalFlags> Flags { get; set; }
		[Ordinal(1)]  [RED("lifeTime")] public CFloat LifeTime { get; set; }
		[Ordinal(2)]  [RED("priority")] public CFloat Priority { get; set; }
		[Ordinal(3)]  [RED("tags")] public CStatic<4,CName> Tags { get; set; }

		public AIGateSignal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
