using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnFindEntityInEntityParams : CVariable
	{
		private scnActorId _actorId;
		private scnPerformerId _performerId;
		private TweakDBID _itemID;
		private TweakDBID _slotID;
		private CBool _forceMaxVisibility;
		private scnPropOwnershipTransferOptions _ownershipTransferOptions;

		[Ordinal(0)] 
		[RED("actorId")] 
		public scnActorId ActorId
		{
			get
			{
				if (_actorId == null)
				{
					_actorId = (scnActorId) CR2WTypeManager.Create("scnActorId", "actorId", cr2w, this);
				}
				return _actorId;
			}
			set
			{
				if (_actorId == value)
				{
					return;
				}
				_actorId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("performerId")] 
		public scnPerformerId PerformerId
		{
			get
			{
				if (_performerId == null)
				{
					_performerId = (scnPerformerId) CR2WTypeManager.Create("scnPerformerId", "performerId", cr2w, this);
				}
				return _performerId;
			}
			set
			{
				if (_performerId == value)
				{
					return;
				}
				_performerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("itemID")] 
		public TweakDBID ItemID
		{
			get
			{
				if (_itemID == null)
				{
					_itemID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "itemID", cr2w, this);
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

		[Ordinal(3)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get
			{
				if (_slotID == null)
				{
					_slotID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "slotID", cr2w, this);
				}
				return _slotID;
			}
			set
			{
				if (_slotID == value)
				{
					return;
				}
				_slotID = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("forceMaxVisibility")] 
		public CBool ForceMaxVisibility
		{
			get
			{
				if (_forceMaxVisibility == null)
				{
					_forceMaxVisibility = (CBool) CR2WTypeManager.Create("Bool", "forceMaxVisibility", cr2w, this);
				}
				return _forceMaxVisibility;
			}
			set
			{
				if (_forceMaxVisibility == value)
				{
					return;
				}
				_forceMaxVisibility = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("ownershipTransferOptions")] 
		public scnPropOwnershipTransferOptions OwnershipTransferOptions
		{
			get
			{
				if (_ownershipTransferOptions == null)
				{
					_ownershipTransferOptions = (scnPropOwnershipTransferOptions) CR2WTypeManager.Create("scnPropOwnershipTransferOptions", "ownershipTransferOptions", cr2w, this);
				}
				return _ownershipTransferOptions;
			}
			set
			{
				if (_ownershipTransferOptions == value)
				{
					return;
				}
				_ownershipTransferOptions = value;
				PropertySet(this);
			}
		}

		public scnFindEntityInEntityParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
