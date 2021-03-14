using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPlayerListGameController : gameuiHUDGameController
	{
		private CArray<PlayerListEntryData> _playerEntries;
		private inkCompoundWidgetReference _container;

		[Ordinal(9)] 
		[RED("playerEntries")] 
		public CArray<PlayerListEntryData> PlayerEntries
		{
			get
			{
				if (_playerEntries == null)
				{
					_playerEntries = (CArray<PlayerListEntryData>) CR2WTypeManager.Create("array:PlayerListEntryData", "playerEntries", cr2w, this);
				}
				return _playerEntries;
			}
			set
			{
				if (_playerEntries == value)
				{
					return;
				}
				_playerEntries = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("container")] 
		public inkCompoundWidgetReference Container
		{
			get
			{
				if (_container == null)
				{
					_container = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "container", cr2w, this);
				}
				return _container;
			}
			set
			{
				if (_container == value)
				{
					return;
				}
				_container = value;
				PropertySet(this);
			}
		}

		public gameuiPlayerListGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
