using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ResolveSensorDeviceBehaviour : redEvent
	{
		[Ordinal(0)] [RED("iteration")] public CInt32 Iteration { get; set; }

		public ResolveSensorDeviceBehaviour(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
