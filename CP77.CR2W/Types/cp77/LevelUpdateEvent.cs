using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class LevelUpdateEvent : redEvent
	{
		[Ordinal(0)] [RED("lvl")] public CInt32 Lvl { get; set; }
		[Ordinal(1)] [RED("type")] public CEnum<gamedataProficiencyType> Type { get; set; }
		[Ordinal(2)] [RED("devPoints")] public CArray<SDevelopmentPoints> DevPoints { get; set; }

		public LevelUpdateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
