using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiWorldMapDistrictLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("record")] 
		public CWeakHandle<gamedataDistrict_Record> Record
		{
			get => GetPropertyValue<CWeakHandle<gamedataDistrict_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataDistrict_Record>>(value);
		}

		[Ordinal(2)] 
		[RED("type")] 
		public CEnum<gamedataDistrict> Type
		{
			get => GetPropertyValue<CEnum<gamedataDistrict>>();
			set => SetPropertyValue<CEnum<gamedataDistrict>>(value);
		}

		[Ordinal(3)] 
		[RED("selected")] 
		public CBool Selected
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("outlineWidget")] 
		public inkLinePatternWidgetReference OutlineWidget
		{
			get => GetPropertyValue<inkLinePatternWidgetReference>();
			set => SetPropertyValue<inkLinePatternWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("iconWidget")] 
		public inkImageWidgetReference IconWidget
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("selectAnim")] 
		public CHandle<inkanimProxy> SelectAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(7)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		public gameuiWorldMapDistrictLogicController()
		{
			OutlineWidget = new();
			IconWidget = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
