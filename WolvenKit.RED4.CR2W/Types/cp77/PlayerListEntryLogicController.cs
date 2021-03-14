using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerListEntryLogicController : inkWidgetLogicController
	{
		private inkWidgetReference _playerNameLabel;
		private inkImageWidgetReference _playerClassIcon;

		[Ordinal(1)] 
		[RED("playerNameLabel")] 
		public inkWidgetReference PlayerNameLabel
		{
			get
			{
				if (_playerNameLabel == null)
				{
					_playerNameLabel = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "playerNameLabel", cr2w, this);
				}
				return _playerNameLabel;
			}
			set
			{
				if (_playerNameLabel == value)
				{
					return;
				}
				_playerNameLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("playerClassIcon")] 
		public inkImageWidgetReference PlayerClassIcon
		{
			get
			{
				if (_playerClassIcon == null)
				{
					_playerClassIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "playerClassIcon", cr2w, this);
				}
				return _playerClassIcon;
			}
			set
			{
				if (_playerClassIcon == value)
				{
					return;
				}
				_playerClassIcon = value;
				PropertySet(this);
			}
		}

		public PlayerListEntryLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
