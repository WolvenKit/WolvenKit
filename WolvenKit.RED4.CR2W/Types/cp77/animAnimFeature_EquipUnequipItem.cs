using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_EquipUnequipItem : animAnimFeature
	{
		private CFloat _stateTransitionDuration;
		private CInt32 _itemState;
		private CInt32 _itemType;
		private CBool _firstEquip;

		[Ordinal(0)] 
		[RED("stateTransitionDuration")] 
		public CFloat StateTransitionDuration
		{
			get
			{
				if (_stateTransitionDuration == null)
				{
					_stateTransitionDuration = (CFloat) CR2WTypeManager.Create("Float", "stateTransitionDuration", cr2w, this);
				}
				return _stateTransitionDuration;
			}
			set
			{
				if (_stateTransitionDuration == value)
				{
					return;
				}
				_stateTransitionDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("itemState")] 
		public CInt32 ItemState
		{
			get
			{
				if (_itemState == null)
				{
					_itemState = (CInt32) CR2WTypeManager.Create("Int32", "itemState", cr2w, this);
				}
				return _itemState;
			}
			set
			{
				if (_itemState == value)
				{
					return;
				}
				_itemState = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("itemType")] 
		public CInt32 ItemType
		{
			get
			{
				if (_itemType == null)
				{
					_itemType = (CInt32) CR2WTypeManager.Create("Int32", "itemType", cr2w, this);
				}
				return _itemType;
			}
			set
			{
				if (_itemType == value)
				{
					return;
				}
				_itemType = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("firstEquip")] 
		public CBool FirstEquip
		{
			get
			{
				if (_firstEquip == null)
				{
					_firstEquip = (CBool) CR2WTypeManager.Create("Bool", "firstEquip", cr2w, this);
				}
				return _firstEquip;
			}
			set
			{
				if (_firstEquip == value)
				{
					return;
				}
				_firstEquip = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_EquipUnequipItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
