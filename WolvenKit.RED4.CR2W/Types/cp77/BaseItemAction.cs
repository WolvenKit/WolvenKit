using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseItemAction : BaseScriptableAction
	{
		private wCHandle<gameItemData> _itemData;
		private CBool _removeAfterUse;
		private CInt32 _quantity;

		[Ordinal(11)] 
		[RED("itemData")] 
		public wCHandle<gameItemData> ItemData
		{
			get => GetProperty(ref _itemData);
			set => SetProperty(ref _itemData, value);
		}

		[Ordinal(12)] 
		[RED("removeAfterUse")] 
		public CBool RemoveAfterUse
		{
			get => GetProperty(ref _removeAfterUse);
			set => SetProperty(ref _removeAfterUse, value);
		}

		[Ordinal(13)] 
		[RED("quantity")] 
		public CInt32 Quantity
		{
			get => GetProperty(ref _quantity);
			set => SetProperty(ref _quantity, value);
		}

		public BaseItemAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
