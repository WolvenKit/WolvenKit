using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameDrawItemByContextRequest : gamePlayerScriptableSystemRequest
	{
		private CEnum<gameItemEquipContexts> _itemEquipContext;
		private CEnum<gameEquipAnimationType> _equipAnimationType;

		[Ordinal(1)] 
		[RED("itemEquipContext")] 
		public CEnum<gameItemEquipContexts> ItemEquipContext
		{
			get
			{
				if (_itemEquipContext == null)
				{
					_itemEquipContext = (CEnum<gameItemEquipContexts>) CR2WTypeManager.Create("gameItemEquipContexts", "itemEquipContext", cr2w, this);
				}
				return _itemEquipContext;
			}
			set
			{
				if (_itemEquipContext == value)
				{
					return;
				}
				_itemEquipContext = value;
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

		public gameDrawItemByContextRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
