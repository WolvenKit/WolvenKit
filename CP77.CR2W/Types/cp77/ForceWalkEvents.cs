using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ForceWalkEvents : LocomotionGroundEvents
	{
		[Ordinal(0)] [RED("storedSpeedValue")] public CFloat StoredSpeedValue { get; set; }

		public ForceWalkEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
