using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CpoCharacterButtonItemController : inkButtonDpadSupportedController
	{
		[Ordinal(0)]  [RED("characterRecordId")] public TweakDBID CharacterRecordId { get; set; }

		public CpoCharacterButtonItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
