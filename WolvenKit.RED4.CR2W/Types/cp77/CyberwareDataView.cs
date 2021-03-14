using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberwareDataView : inkScriptableDataViewWrapper
	{
		private CEnum<RipperdocFilter> _itemFilterType;
		private CEnum<ItemSortMode> _itemSortMode;
		private wCHandle<UIScriptableSystem> _uiScriptableSystem;

		[Ordinal(0)] 
		[RED("itemFilterType")] 
		public CEnum<RipperdocFilter> ItemFilterType
		{
			get
			{
				if (_itemFilterType == null)
				{
					_itemFilterType = (CEnum<RipperdocFilter>) CR2WTypeManager.Create("RipperdocFilter", "itemFilterType", cr2w, this);
				}
				return _itemFilterType;
			}
			set
			{
				if (_itemFilterType == value)
				{
					return;
				}
				_itemFilterType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("itemSortMode")] 
		public CEnum<ItemSortMode> ItemSortMode
		{
			get
			{
				if (_itemSortMode == null)
				{
					_itemSortMode = (CEnum<ItemSortMode>) CR2WTypeManager.Create("ItemSortMode", "itemSortMode", cr2w, this);
				}
				return _itemSortMode;
			}
			set
			{
				if (_itemSortMode == value)
				{
					return;
				}
				_itemSortMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("uiScriptableSystem")] 
		public wCHandle<UIScriptableSystem> UiScriptableSystem
		{
			get
			{
				if (_uiScriptableSystem == null)
				{
					_uiScriptableSystem = (wCHandle<UIScriptableSystem>) CR2WTypeManager.Create("whandle:UIScriptableSystem", "uiScriptableSystem", cr2w, this);
				}
				return _uiScriptableSystem;
			}
			set
			{
				if (_uiScriptableSystem == value)
				{
					return;
				}
				_uiScriptableSystem = value;
				PropertySet(this);
			}
		}

		public CyberwareDataView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
