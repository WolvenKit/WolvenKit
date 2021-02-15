using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SuppressOutlineEvent : redEvent
	{
		[Ordinal(0)] [RED("requestToSuppress")] public CHandle<OutlineRequest> RequestToSuppress { get; set; }

		public SuppressOutlineEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
