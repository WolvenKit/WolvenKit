using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workEquipPropToSlotAction : workIWorkspotItemAction
	{
		private CName _itemId;
		private TweakDBID _itemSlot;
		private CEnum<workPropAttachMethod> _attachMethod;
		private Vector3 _customOffsetPos;
		private Quaternion _customOffsetRot;

		[Ordinal(0)] 
		[RED("itemId")] 
		public CName ItemId
		{
			get
			{
				if (_itemId == null)
				{
					_itemId = (CName) CR2WTypeManager.Create("CName", "itemId", cr2w, this);
				}
				return _itemId;
			}
			set
			{
				if (_itemId == value)
				{
					return;
				}
				_itemId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("itemSlot")] 
		public TweakDBID ItemSlot
		{
			get
			{
				if (_itemSlot == null)
				{
					_itemSlot = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "itemSlot", cr2w, this);
				}
				return _itemSlot;
			}
			set
			{
				if (_itemSlot == value)
				{
					return;
				}
				_itemSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("attachMethod")] 
		public CEnum<workPropAttachMethod> AttachMethod
		{
			get
			{
				if (_attachMethod == null)
				{
					_attachMethod = (CEnum<workPropAttachMethod>) CR2WTypeManager.Create("workPropAttachMethod", "attachMethod", cr2w, this);
				}
				return _attachMethod;
			}
			set
			{
				if (_attachMethod == value)
				{
					return;
				}
				_attachMethod = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("customOffsetPos")] 
		public Vector3 CustomOffsetPos
		{
			get
			{
				if (_customOffsetPos == null)
				{
					_customOffsetPos = (Vector3) CR2WTypeManager.Create("Vector3", "customOffsetPos", cr2w, this);
				}
				return _customOffsetPos;
			}
			set
			{
				if (_customOffsetPos == value)
				{
					return;
				}
				_customOffsetPos = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("customOffsetRot")] 
		public Quaternion CustomOffsetRot
		{
			get
			{
				if (_customOffsetRot == null)
				{
					_customOffsetRot = (Quaternion) CR2WTypeManager.Create("Quaternion", "customOffsetRot", cr2w, this);
				}
				return _customOffsetRot;
			}
			set
			{
				if (_customOffsetRot == value)
				{
					return;
				}
				_customOffsetRot = value;
				PropertySet(this);
			}
		}

		public workEquipPropToSlotAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
