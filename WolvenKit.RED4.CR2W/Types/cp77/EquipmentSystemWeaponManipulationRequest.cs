using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EquipmentSystemWeaponManipulationRequest : gamePlayerScriptableSystemRequest
	{
		private CEnum<EquipmentManipulationAction> _requestType;
		private CEnum<gameEquipAnimationType> _equipAnimType;
		private CBool _removeItemFromEquipSlot;

		[Ordinal(1)] 
		[RED("requestType")] 
		public CEnum<EquipmentManipulationAction> RequestType
		{
			get
			{
				if (_requestType == null)
				{
					_requestType = (CEnum<EquipmentManipulationAction>) CR2WTypeManager.Create("EquipmentManipulationAction", "requestType", cr2w, this);
				}
				return _requestType;
			}
			set
			{
				if (_requestType == value)
				{
					return;
				}
				_requestType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("equipAnimType")] 
		public CEnum<gameEquipAnimationType> EquipAnimType
		{
			get
			{
				if (_equipAnimType == null)
				{
					_equipAnimType = (CEnum<gameEquipAnimationType>) CR2WTypeManager.Create("gameEquipAnimationType", "equipAnimType", cr2w, this);
				}
				return _equipAnimType;
			}
			set
			{
				if (_equipAnimType == value)
				{
					return;
				}
				_equipAnimType = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("removeItemFromEquipSlot")] 
		public CBool RemoveItemFromEquipSlot
		{
			get
			{
				if (_removeItemFromEquipSlot == null)
				{
					_removeItemFromEquipSlot = (CBool) CR2WTypeManager.Create("Bool", "removeItemFromEquipSlot", cr2w, this);
				}
				return _removeItemFromEquipSlot;
			}
			set
			{
				if (_removeItemFromEquipSlot == value)
				{
					return;
				}
				_removeItemFromEquipSlot = value;
				PropertySet(this);
			}
		}

		public EquipmentSystemWeaponManipulationRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
