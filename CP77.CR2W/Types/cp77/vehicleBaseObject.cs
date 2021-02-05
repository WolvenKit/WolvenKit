using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class vehicleBaseObject : gameObject
	{
		[Ordinal(0)]  [RED("archetype")] public rRef<AIArchetype> Archetype { get; set; }

		public vehicleBaseObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
