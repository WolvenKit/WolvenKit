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
			get => GetProperty(ref _statsRoot);
			set => SetProperty(ref _statsRoot, value);
		}

		[Ordinal(2)] 
		[RED("StatItemName")] 
		public CName StatItemName
		{
			get => GetProperty(ref _statItemName);
			set => SetProperty(ref _statItemName, value);
		}

		[Ordinal(3)] 
		[RED("StatItems")] 
		public CArray<wCHandle<InventoryStatItemV2>> StatItems
		{
			get => GetProperty(ref _statItems);
			set => SetProperty(ref _statItems, value);
		}

		public InventoryStatsDisplay(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
