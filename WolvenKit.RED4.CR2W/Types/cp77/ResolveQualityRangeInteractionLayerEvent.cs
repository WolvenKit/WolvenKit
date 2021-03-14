using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ResolveQualityRangeInteractionLayerEvent : redEvent
	{
		private wCHandle<gameItemData> _itemData;

		[Ordinal(0)] 
		[RED("itemData")] 
		public wCHandle<gameItemData> ItemData
		{
			get
			{
				if (_itemData == null)
				{
					_itemData = (wCHandle<gameItemData>) CR2WTypeManager.Create("whandle:gameItemData", "itemData", cr2w, this);
				}
				return _itemData;
			}
			set
			{
				if (_itemData == value)
				{
					return;
				}
				_itemData = value;
				PropertySet(this);
			}
		}

		public ResolveQualityRangeInteractionLayerEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
