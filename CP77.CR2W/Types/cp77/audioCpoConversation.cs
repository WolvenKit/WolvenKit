using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioCpoConversation : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("characterOne")] public CEnum<audioVoCpoCharacter> CharacterOne { get; set; }
		[Ordinal(1)]  [RED("characterTwo")] public CEnum<audioVoCpoCharacter> CharacterTwo { get; set; }
		[Ordinal(2)]  [RED("voTriggers")] public CArray<CName> VoTriggers { get; set; }

		public audioCpoConversation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
