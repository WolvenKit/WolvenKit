using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnPropOwnershipTransferOptions : CVariable
	{
		private CEnum<scnPropOwnershipTransferOptionsType> _type;
		private CBool _dettachFromSlot;
		private CBool _removeFromInventory;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<scnPropOwnershipTransferOptionsType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<scnPropOwnershipTransferOptionsType>) CR2WTypeManager.Create("scnPropOwnershipTransferOptionsType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("dettachFromSlot")] 
		public CBool DettachFromSlot
		{
			get
			{
				if (_dettachFromSlot == null)
				{
					_dettachFromSlot = (CBool) CR2WTypeManager.Create("Bool", "dettachFromSlot", cr2w, this);
				}
				return _dettachFromSlot;
			}
			set
			{
				if (_dettachFromSlot == value)
				{
					return;
				}
				_dettachFromSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("removeFromInventory")] 
		public CBool RemoveFromInventory
		{
			get
			{
				if (_removeFromInventory == null)
				{
					_removeFromInventory = (CBool) CR2WTypeManager.Create("Bool", "removeFromInventory", cr2w, this);
				}
				return _removeFromInventory;
			}
			set
			{
				if (_removeFromInventory == value)
				{
					return;
				}
				_removeFromInventory = value;
				PropertySet(this);
			}
		}

		public scnPropOwnershipTransferOptions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
