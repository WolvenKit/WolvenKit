using CP77.CR2W.Reflection;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DurabilityLimitReach : redEvent
	{
		public DurabilityLimitReach(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
