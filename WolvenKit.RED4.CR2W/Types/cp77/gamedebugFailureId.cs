using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedebugFailureId : CVariable
	{
		[Ordinal(0)] [RED("threadId")] public CUInt32 ThreadId { get; set; }
		[Ordinal(1)] [RED("unsignedId")] public CUInt32 UnsignedId { get; set; }

		public gamedebugFailureId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
