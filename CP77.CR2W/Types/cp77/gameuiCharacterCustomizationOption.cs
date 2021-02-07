using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationOption : IScriptable
	{
		[Ordinal(0)]  [RED("info")] public CHandle<gameuiCharacterCustomizationInfo> Info { get; set; }
		[Ordinal(1)]  [RED("bodyPart")] public CEnum<gameuiCharacterCustomizationPart> BodyPart { get; set; }
		[Ordinal(2)]  [RED("prevIndex")] public CUInt32 PrevIndex { get; set; }
		[Ordinal(3)]  [RED("currIndex")] public CUInt32 CurrIndex { get; set; }
		[Ordinal(4)]  [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(5)]  [RED("isCensored")] public CBool IsCensored { get; set; }

		public gameuiCharacterCustomizationOption(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
