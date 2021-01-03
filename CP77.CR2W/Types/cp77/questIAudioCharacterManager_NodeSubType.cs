using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questIAudioCharacterManager_NodeSubType : questINodeType
	{
		[Ordinal(0)]  [RED("characterEntries")] public CArray<questIAudioCharacterManager_NodeSubTypeCharacterEntry> CharacterEntries { get; set; }

		public questIAudioCharacterManager_NodeSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
