using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryStatsDisplay : inkWidgetLogicController
	{
		private inkCompoundWidgetReference _statsRoot;
		private CName _statItemName;
		private CArray<wCHandle<InventoryStatItemV2>> _statItems;

		[Ordinal(1)] 
		[RED("StatsRoot")] 
		public inkCompoundWidgetReference StatsRoot
		{
			get
			{
				if (_statsRoot == null)
				{
					_statsRoot = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "StatsRoot", cr2w, this);
				}
				return _statsRoot;
			}
			set
			{
				if (_statsRoot == value)
				{
					return;
				}
				_statsRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("StatItemName")] 
		public CName StatItemName
		{
			get
			{
				if (_statItemName == null)
				{
					_statItemName = (CName) CR2WTypeManager.Create("CName", "StatItemName", cr2w, this);
				}
				return _statItemName;
			}
			set
			{
				if (_statItemName == value)
				{
					return;
				}
				_statItemName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("StatItems")] 
		public CArray<wCHandle<InventoryStatItemV2>> StatItems
		{
			get
			{
				if (_statItems == null)
				{
					_statItems = (CArray<wCHandle<InventoryStatItemV2>>) CR2WTypeManager.Create("array:whandle:InventoryStatItemV2", "StatItems", cr2w, this);
				}
				return _statItems;
			}
			set
			{
				if (_statItems == value)
				{
					return;
				}
				_statItems = value;
				PropertySet(this);
			}
		}

		public InventoryStatsDisplay(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
