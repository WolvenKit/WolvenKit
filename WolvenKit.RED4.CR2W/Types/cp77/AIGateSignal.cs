using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIGateSignal : CVariable
	{
		[Ordinal(0)] [RED("tags", 4)] public CStatic<CName> Tags { get; set; }
		[Ordinal(1)] [RED("flags")] public CEnum<AISignalFlags> Flags { get; set; }
		[Ordinal(2)] [RED("priority")] public CFloat Priority { get; set; }
		[Ordinal(3)] [RED("lifeTime")] public CFloat LifeTime { get; set; }

		public AIGateSignal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
