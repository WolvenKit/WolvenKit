using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CompanionHealthStatListener : gameScriptStatPoolsListener
	{
		[Ordinal(0)] [RED("healthbar")] public CHandle<CompanionHealthBarGameController> Healthbar { get; set; }

		public CompanionHealthStatListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
