using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorBehaviorInstanceCallStack : CVariable
	{
		[Ordinal(0)] [RED("resourceHashes")] public CArray<CUInt32> ResourceHashes { get; set; }

		public AIbehaviorBehaviorInstanceCallStack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
