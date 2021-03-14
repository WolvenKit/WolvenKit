using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemCraftedDataTrackingRequest : gamePlayerScriptableSystemRequest
	{
		private gameItemID _targetItem;

		[Ordinal(1)] 
		[RED("targetItem")] 
		public gameItemID TargetItem
		{
			get
			{
				if (_targetItem == null)
				{
					_targetItem = (gameItemID) CR2WTypeManager.Create("gameItemID", "targetItem", cr2w, this);
				}
				return _targetItem;
			}
			set
			{
				if (_targetItem == value)
				{
					return;
				}
				_targetItem = value;
				PropertySet(this);
			}
		}

		public ItemCraftedDataTrackingRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
