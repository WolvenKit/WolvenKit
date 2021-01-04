using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioSoundBankStruct : CVariable
	{
		[Ordinal(0)]  [RED("soundBank")] public CName SoundBank { get; set; }

		public audioSoundBankStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
