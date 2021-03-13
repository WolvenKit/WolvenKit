using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameSignalPriorityDefinition : ISerializable
	{
		[Ordinal(0)] [RED("defaultPriority")] public CUInt16 DefaultPriority { get; set; }

		public gameSignalPriorityDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
