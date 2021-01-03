using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class EndScreenData : CVariable
	{
		[Ordinal(0)]  [RED("outcome")] public CEnum<OutcomeMessage> Outcome { get; set; }
		[Ordinal(1)]  [RED("unlockedPrograms")] public CArray<ProgramData> UnlockedPrograms { get; set; }

		public EndScreenData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
