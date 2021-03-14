using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioCpoConversation : audioAudioMetadata
	{
		private CEnum<audioVoCpoCharacter> _characterOne;
		private CEnum<audioVoCpoCharacter> _characterTwo;
		private CArray<CName> _voTriggers;

		[Ordinal(1)] 
		[RED("characterOne")] 
		public CEnum<audioVoCpoCharacter> CharacterOne
		{
			get
			{
				if (_characterOne == null)
				{
					_characterOne = (CEnum<audioVoCpoCharacter>) CR2WTypeManager.Create("audioVoCpoCharacter", "characterOne", cr2w, this);
				}
				return _characterOne;
			}
			set
			{
				if (_characterOne == value)
				{
					return;
				}
				_characterOne = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("characterTwo")] 
		public CEnum<audioVoCpoCharacter> CharacterTwo
		{
			get
			{
				if (_characterTwo == null)
				{
					_characterTwo = (CEnum<audioVoCpoCharacter>) CR2WTypeManager.Create("audioVoCpoCharacter", "characterTwo", cr2w, this);
				}
				return _characterTwo;
			}
			set
			{
				if (_characterTwo == value)
				{
					return;
				}
				_characterTwo = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("voTriggers")] 
		public CArray<CName> VoTriggers
		{
			get
			{
				if (_voTriggers == null)
				{
					_voTriggers = (CArray<CName>) CR2WTypeManager.Create("array:CName", "voTriggers", cr2w, this);
				}
				return _voTriggers;
			}
			set
			{
				if (_voTriggers == value)
				{
					return;
				}
				_voTriggers = value;
				PropertySet(this);
			}
		}

		public audioCpoConversation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
