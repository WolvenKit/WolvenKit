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
			get
			{
				if (_characterEntries == null)
				{
					_characterEntries = (CArray<questIAudioCharacterManager_NodeSubTypeCharacterEntry>) CR2WTypeManager.Create("array:questIAudioCharacterManager_NodeSubTypeCharacterEntry", "characterEntries", cr2w, this);
				}
				return _characterEntries;
			}
			set
			{
				if (_characterEntries == value)
				{
					return;
				}
				_characterEntries = value;
				PropertySet(this);
			}
		}

		public questIAudioCharacterManager_NodeSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
