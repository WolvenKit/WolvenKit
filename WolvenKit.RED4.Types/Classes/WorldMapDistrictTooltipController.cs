using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WorldMapDistrictTooltipController : WorldMapTooltipBaseController
	{
		[Ordinal(5)] 
		[RED("titleText")] 
		public inkTextWidgetReference TitleText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("levelRangeText")] 
		public inkTextWidgetReference LevelRangeText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("threatText")] 
		public inkTextWidgetReference ThreatText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("completionText")] 
		public inkTextWidgetReference CompletionText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("gangsContainer")] 
		public inkWidgetReference GangsContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("gangsList")] 
		public inkCompoundWidgetReference GangsList
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("gangControllers")] 
		public CArray<CWeakHandle<WorldMapGangItemController>> GangControllers
		{
			get => GetPropertyValue<CArray<CWeakHandle<WorldMapGangItemController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<WorldMapGangItemController>>>(value);
		}

		public WorldMapDistrictTooltipController()
		{
			TitleText = new();
			LevelRangeText = new();
			ThreatText = new();
			CompletionText = new();
			GangsContainer = new();
			GangsList = new();
			GangControllers = new();
		}
	}
}
