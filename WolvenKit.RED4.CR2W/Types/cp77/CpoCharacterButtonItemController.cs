using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CpoCharacterButtonItemController : inkButtonDpadSupportedController
	{
		private TweakDBID _characterRecordId;

		[Ordinal(26)] 
		[RED("characterRecordId")] 
		public TweakDBID CharacterRecordId
		{
			get
			{
				if (_characterRecordId == null)
				{
					_characterRecordId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "characterRecordId", cr2w, this);
				}
				return _characterRecordId;
			}
			set
			{
				if (_characterRecordId == value)
				{
					return;
				}
				_characterRecordId = value;
				PropertySet(this);
			}
		}

		public CpoCharacterButtonItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
