using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameReplAnimTransformRequestBase : CVariable
	{
		[Ordinal(0)]  [RED("applyServerTime")] public netTime ApplyServerTime { get; set; }

		public gameReplAnimTransformRequestBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
