using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class QueueCombatExperience : gamePlayerScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("amount")] public CFloat Amount { get; set; }
		[Ordinal(1)]  [RED("entity")] public entEntityID Entity { get; set; }
		[Ordinal(2)]  [RED("experienceType")] public CEnum<gamedataProficiencyType> ExperienceType { get; set; }

		public QueueCombatExperience(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
