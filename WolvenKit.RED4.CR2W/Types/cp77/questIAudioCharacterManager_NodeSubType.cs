using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questIAudioCharacterManager_NodeSubType : questINodeType
	{
		[Ordinal(0)] [RED("characterEntries")] public CArray<questIAudioCharacterManager_NodeSubTypeCharacterEntry> CharacterEntries { get; set; }

		public questIAudioCharacterManager_NodeSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
