using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ExperiencePointsEvent : redEvent
	{
		[Ordinal(0)]  [RED("amount")] public CInt32 Amount { get; set; }
		[Ordinal(1)]  [RED("isDebug")] public CBool IsDebug { get; set; }
		[Ordinal(2)]  [RED("type")] public CEnum<gamedataProficiencyType> Type { get; set; }

		public ExperiencePointsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
