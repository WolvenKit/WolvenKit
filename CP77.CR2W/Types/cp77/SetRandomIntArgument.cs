using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SetRandomIntArgument : AIRandomTasks
	{
		[Ordinal(0)]  [RED("ArgumentName")] public CName ArgumentName { get; set; }
		[Ordinal(1)]  [RED("MaxValue")] public CInt32 MaxValue { get; set; }
		[Ordinal(2)]  [RED("MinValue")] public CInt32 MinValue { get; set; }

		public SetRandomIntArgument(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
