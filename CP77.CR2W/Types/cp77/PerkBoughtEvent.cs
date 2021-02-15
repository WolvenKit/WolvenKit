using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PerkBoughtEvent : redEvent
	{
		[Ordinal(0)] [RED("perkType")] public CEnum<gamedataPerkType> PerkType { get; set; }

		public PerkBoughtEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
