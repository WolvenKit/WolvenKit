using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ScannerAbilitiesGameController : BaseChunkGameController
	{
		[Ordinal(3)]  [RED("ScannerAbilitiesRightPanel")] public inkCompoundWidgetReference ScannerAbilitiesRightPanel { get; set; }
		[Ordinal(4)]  [RED("abilitiesCallbackID")] public CUInt32 AbilitiesCallbackID { get; set; }
		[Ordinal(5)]  [RED("isValidAbilities")] public CBool IsValidAbilities { get; set; }
		[Ordinal(6)]  [RED("abilityWidgets")] public CArray<wCHandle<inkWidget>> AbilityWidgets { get; set; }

		public ScannerAbilitiesGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
