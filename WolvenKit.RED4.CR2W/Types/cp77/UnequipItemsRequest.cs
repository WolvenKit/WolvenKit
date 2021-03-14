using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UnequipItemsRequest : gamePlayerScriptableSystemRequest
	{
		private CArray<gameItemID> _items;

		[Ordinal(1)] 
		[RED("items")] 
		public CArray<gameItemID> Items
		{
			get
			{
				if (_items == null)
				{
					_items = (CArray<gameItemID>) CR2WTypeManager.Create("array:gameItemID", "items", cr2w, this);
				}
				return _items;
			}
			set
			{
				if (_items == value)
				{
					return;
				}
				_items = value;
				PropertySet(this);
			}
		}

		public UnequipItemsRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
