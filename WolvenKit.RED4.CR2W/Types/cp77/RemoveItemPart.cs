using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RemoveItemPart : gameScriptableSystemRequest
	{
		private wCHandle<gameObject> _obj;
		private gameItemID _baseItem;
		private TweakDBID _slotToEmpty;

		[Ordinal(0)] 
		[RED("obj")] 
		public wCHandle<gameObject> Obj
		{
			get
			{
				if (_obj == null)
				{
					_obj = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "obj", cr2w, this);
				}
				return _obj;
			}
			set
			{
				if (_obj == value)
				{
					return;
				}
				_obj = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("baseItem")] 
		public gameItemID BaseItem
		{
			get
			{
				if (_baseItem == null)
				{
					_baseItem = (gameItemID) CR2WTypeManager.Create("gameItemID", "baseItem", cr2w, this);
				}
				return _baseItem;
			}
			set
			{
				if (_baseItem == value)
				{
					return;
				}
				_baseItem = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("slotToEmpty")] 
		public TweakDBID SlotToEmpty
		{
			get
			{
				if (_slotToEmpty == null)
				{
					_slotToEmpty = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "slotToEmpty", cr2w, this);
				}
				return _slotToEmpty;
			}
			set
			{
				if (_slotToEmpty == value)
				{
					return;
				}
				_slotToEmpty = value;
				PropertySet(this);
			}
		}

		public RemoveItemPart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
