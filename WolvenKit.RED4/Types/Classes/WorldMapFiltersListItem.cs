using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WorldMapFiltersListItem : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("checker")] 
		public inkWidgetReference Checker
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("filterName")] 
		public inkTextWidgetReference FilterName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("filterGroup")] 
		public CWeakHandle<gamedataMappinUIFilterGroup_Record> FilterGroup
		{
			get => GetPropertyValue<CWeakHandle<gamedataMappinUIFilterGroup_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataMappinUIFilterGroup_Record>>(value);
		}

		[Ordinal(4)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(5)] 
		[RED("isHovered")] 
		public CBool IsHovered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public WorldMapFiltersListItem()
		{
			Checker = new inkWidgetReference();
			FilterName = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
