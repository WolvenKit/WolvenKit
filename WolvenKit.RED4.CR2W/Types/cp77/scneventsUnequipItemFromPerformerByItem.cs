using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsUnequipItemFromPerformerByItem : scnSceneEvent
	{
		private scnPerformerId _performerId;
		private TweakDBID _itemId;
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

		public scneventsUnequipItemFromPerformerByItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
