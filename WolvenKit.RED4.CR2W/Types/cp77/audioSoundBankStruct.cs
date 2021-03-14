using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioSoundBankStruct : CVariable
	{
		[Ordinal(0)] [RED("soundBank")] public CName SoundBank { get; set; }

		public audioSoundBankStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
