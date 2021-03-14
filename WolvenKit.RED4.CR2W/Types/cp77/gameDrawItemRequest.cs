using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameDrawItemRequest : gamePlayerScriptableSystemRequest
	{
		private gameItemID _itemID;
		private CEnum<gameEquipAnimationType> _equipAnimationType;
		private CBool _assignOnly;

		[Ordinal(1)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get
			{
				if (_itemID == null)
				{
					_itemID = (gameItemID) CR2WTypeManager.Create("gameItemID", "itemID", cr2w, this);
				}
				return _itemID;
			}
			set
			{
				if (_itemID == value)
				{
					return;
				}
				_itemID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("equipAnimationType")] 
		public CEnum<gameEquipAnimationType> EquipAnimationType
		{
			get
			{
				if (_equipAnimationType == null)
				{
					_equipAnimationType = (CEnum<gameEquipAnimationType>) CR2WTypeManager.Create("gameEquipAnimationType", "equipAnimationType", cr2w, this);
				}
				return _equipAnimationType;
			}
			set
			{
				if (_equipAnimationType == value)
				{
					return;
				}
				_equipAnimationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("assignOnly")] 
		public CBool AssignOnly
		{
			get
			{
				if (_assignOnly == null)
				{
					_assignOnly = (CBool) CR2WTypeManager.Create("Bool", "assignOnly", cr2w, this);
				}
				return _assignOnly;
			}
			set
			{
				if (_assignOnly == value)
				{
					return;
				}
				_assignOnly = value;
				PropertySet(this);
			}
		}

		public gameDrawItemRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
