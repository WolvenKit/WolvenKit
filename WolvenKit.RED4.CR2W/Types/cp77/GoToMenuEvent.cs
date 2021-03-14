using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GoToMenuEvent : redEvent
	{
		private CEnum<EComputerMenuType> _menuType;
		private CBool _wakeUp;
		private entEntityID _ownerID;

		[Ordinal(0)] 
		[RED("menuType")] 
		public CEnum<EComputerMenuType> MenuType
		{
			get
			{
				if (_menuType == null)
				{
					_menuType = (CEnum<EComputerMenuType>) CR2WTypeManager.Create("EComputerMenuType", "menuType", cr2w, this);
				}
				return _menuType;
			}
			set
			{
				if (_menuType == value)
				{
					return;
				}
				_menuType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("wakeUp")] 
		public CBool WakeUp
		{
			get
			{
				if (_wakeUp == null)
				{
					_wakeUp = (CBool) CR2WTypeManager.Create("Bool", "wakeUp", cr2w, this);
				}
				return _wakeUp;
			}
			set
			{
				if (_wakeUp == value)
				{
					return;
				}
				_wakeUp = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get
			{
				if (_ownerID == null)
				{
					_ownerID = (entEntityID) CR2WTypeManager.Create("entEntityID", "ownerID", cr2w, this);
				}
				return _ownerID;
			}
			set
			{
				if (_ownerID == value)
				{
					return;
				}
				_ownerID = value;
				PropertySet(this);
			}
		}

		public GoToMenuEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
