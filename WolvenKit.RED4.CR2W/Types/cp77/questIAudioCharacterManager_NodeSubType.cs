using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questIAudioCharacterManager_NodeSubType : questINodeType
	{
		private CArray<questIAudioCharacterManager_NodeSubTypeCharacterEntry> _characterEntries;

		[Ordinal(0)] 
		[RED("characterEntries")] 
		public CArray<questIAudioCharacterManager_NodeSubTypeCharacterEntry> CharacterEntries
		{
			get => GetProperty(ref _characterEntries);
			set => SetProperty(ref _characterEntries, value);
		}

		public questIAudioCharacterManager_NodeSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
