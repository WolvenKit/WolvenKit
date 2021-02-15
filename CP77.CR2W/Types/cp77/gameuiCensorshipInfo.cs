using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiCensorshipInfo : CVariable
	{
		[Ordinal(0)] [RED("censorFlag")] public CEnum<CensorshipFlags> CensorFlag { get; set; }
		[Ordinal(1)] [RED("censorFlagAction")] public CEnum<gameuiCharacterCustomizationActionType> CensorFlagAction { get; set; }

		public gameuiCensorshipInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
