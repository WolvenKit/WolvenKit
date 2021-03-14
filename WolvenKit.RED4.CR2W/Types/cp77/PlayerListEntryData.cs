using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerListEntryData : CVariable
	{
		private wCHandle<gameObject> _playerObject;
		private wCHandle<inkWidget> _playerListEntry;

		[Ordinal(0)] 
		[RED("playerObject")] 
		public wCHandle<gameObject> PlayerObject
		{
			get
			{
				if (_playerObject == null)
				{
					_playerObject = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "playerObject", cr2w, this);
				}
				return _playerObject;
			}
			set
			{
				if (_playerObject == value)
				{
					return;
				}
				_playerObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("playerListEntry")] 
		public wCHandle<inkWidget> PlayerListEntry
		{
			get
			{
				if (_playerListEntry == null)
				{
					_playerListEntry = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "playerListEntry", cr2w, this);
				}
				return _playerListEntry;
			}
			set
			{
				if (_playerListEntry == value)
				{
					return;
				}
				_playerListEntry = value;
				PropertySet(this);
			}
		}

		public PlayerListEntryData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
