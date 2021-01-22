using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ProcessQueuedCombatExperience : gamePlayerScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("entity")] public entEntityID Entity { get; set; }

		public ProcessQueuedCombatExperience(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
