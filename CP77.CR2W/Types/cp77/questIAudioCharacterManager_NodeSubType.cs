using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questIAudioCharacterManager_NodeSubType : questINodeType
	{
		[Ordinal(0)]  [RED("characterEntries")] public CArray<questIAudioCharacterManager_NodeSubTypeCharacterEntry> CharacterEntries { get; set; }

		public questIAudioCharacterManager_NodeSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
