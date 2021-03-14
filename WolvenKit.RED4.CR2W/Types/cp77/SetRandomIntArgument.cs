using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetRandomIntArgument : AIRandomTasks
	{
		[Ordinal(0)] [RED("MaxValue")] public CInt32 MaxValue { get; set; }
		[Ordinal(1)] [RED("MinValue")] public CInt32 MinValue { get; set; }
		[Ordinal(2)] [RED("ArgumentName")] public CName ArgumentName { get; set; }

		public SetRandomIntArgument(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
