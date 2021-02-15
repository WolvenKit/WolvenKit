using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CpoCharacterButtonItemController : inkButtonDpadSupportedController
	{
		[Ordinal(26)] [RED("characterRecordId")] public TweakDBID CharacterRecordId { get; set; }

		public CpoCharacterButtonItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
