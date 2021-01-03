using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ProcessQueuedCombatExperience : gamePlayerScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("entity")] public entEntityID Entity { get; set; }

		public ProcessQueuedCombatExperience(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
