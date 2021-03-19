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
			get => GetProperty(ref _targetItem);
			set => SetProperty(ref _targetItem, value);
		}

		public ItemCraftedDataTrackingRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
