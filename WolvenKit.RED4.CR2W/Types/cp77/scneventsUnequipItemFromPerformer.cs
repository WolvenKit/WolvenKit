using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsUnequipItemFromPerformer : scnSceneEvent
	{
		private scnPerformerId _performerId;
		private TweakDBID _slotId;
		private CBool _restoreGameplayItem;

		[Ordinal(6)] 
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

		[Ordinal(7)] 
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

		[Ordinal(8)] 
		[RED("restoreGameplayItem")] 
		public CBool RestoreGameplayItem
		{
			get
			{
				if (_restoreGameplayItem == null)
				{
					_restoreGameplayItem = (CBool) CR2WTypeManager.Create("Bool", "restoreGameplayItem", cr2w, this);
				}
				return _restoreGameplayItem;
			}
			set
			{
				if (_restoreGameplayItem == value)
				{
					return;
				}
				_restoreGameplayItem = value;
				PropertySet(this);
			}
		}

		public scneventsUnequipItemFromPerformer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
