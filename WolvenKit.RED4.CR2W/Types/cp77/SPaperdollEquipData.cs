using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SPaperdollEquipData : CVariable
	{
		private gameSEquipArea _equipArea;
		private CInt32 _slotIndex;
		private TweakDBID _placementSlot;
		private CBool _equipped;

		[Ordinal(0)] 
		[RED("equipArea")] 
		public gameSEquipArea EquipArea
		{
			get
			{
				if (_equipArea == null)
				{
					_equipArea = (gameSEquipArea) CR2WTypeManager.Create("gameSEquipArea", "equipArea", cr2w, this);
				}
				return _equipArea;
			}
			set
			{
				if (_equipArea == value)
				{
					return;
				}
				_equipArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("slotIndex")] 
		public CInt32 SlotIndex
		{
			get
			{
				if (_slotIndex == null)
				{
					_slotIndex = (CInt32) CR2WTypeManager.Create("Int32", "slotIndex", cr2w, this);
				}
				return _slotIndex;
			}
			set
			{
				if (_slotIndex == value)
				{
					return;
				}
				_slotIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("placementSlot")] 
		public TweakDBID PlacementSlot
		{
			get
			{
				if (_placementSlot == null)
				{
					_placementSlot = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "placementSlot", cr2w, this);
				}
				return _placementSlot;
			}
			set
			{
				if (_placementSlot == value)
				{
					return;
				}
				_placementSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("equipped")] 
		public CBool Equipped
		{
			get
			{
				if (_equipped == null)
				{
					_equipped = (CBool) CR2WTypeManager.Create("Bool", "equipped", cr2w, this);
				}
				return _equipped;
			}
			set
			{
				if (_equipped == value)
				{
					return;
				}
				_equipped = value;
				PropertySet(this);
			}
		}

		public SPaperdollEquipData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
