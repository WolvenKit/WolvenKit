using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIEquipCommand : AICommand
	{
		private TweakDBID _slotId;
		private TweakDBID _itemId;
		private CBool _failIfItemNotFound;
		private CFloat _durationOverride;

		[Ordinal(4)] 
		[RED("slotId")] 
		public TweakDBID SlotId
		{
			get
			{
				if (_slotId == null)
				{
					_slotId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "slotId", cr2w, this);
				}
				return _slotId;
			}
			set
			{
				if (_slotId == value)
				{
					return;
				}
				_slotId = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("itemId")] 
		public TweakDBID ItemId
		{
			get
			{
				if (_itemId == null)
				{
					_itemId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "itemId", cr2w, this);
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

		[Ordinal(6)] 
		[RED("failIfItemNotFound")] 
		public CBool FailIfItemNotFound
		{
			get
			{
				if (_failIfItemNotFound == null)
				{
					_failIfItemNotFound = (CBool) CR2WTypeManager.Create("Bool", "failIfItemNotFound", cr2w, this);
				}
				return _failIfItemNotFound;
			}
			set
			{
				if (_failIfItemNotFound == value)
				{
					return;
				}
				_failIfItemNotFound = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("durationOverride")] 
		public CFloat DurationOverride
		{
			get
			{
				if (_durationOverride == null)
				{
					_durationOverride = (CFloat) CR2WTypeManager.Create("Float", "durationOverride", cr2w, this);
				}
				return _durationOverride;
			}
			set
			{
				if (_durationOverride == value)
				{
					return;
				}
				_durationOverride = value;
				PropertySet(this);
			}
		}

		public AIEquipCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
