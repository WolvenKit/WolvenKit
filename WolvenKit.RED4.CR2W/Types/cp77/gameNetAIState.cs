using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameNetAIState : CVariable
	{
		[Ordinal(0)] [RED("value")] public CInt32 Value { get; set; }
		[Ordinal(1)] [RED("prevValue")] public CInt32 PrevValue { get; set; }
		[Ordinal(2)] [RED("time")] public CFloat Time { get; set; }

		public gameNetAIState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
